using System;
using System.Buffers;
using System.IO;
using System.Security.Cryptography;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace PerformanceExperiments;

public static class SymmetricAlgorithmExtensions
{
	class FakeMemoryOwner : IMemoryOwner<byte>
	{
		private readonly Action? _onDispose;

		public FakeMemoryOwner(Memory<byte> Memory, Action? onDispose = null)
		{
			this.Memory = Memory;
			this._onDispose = onDispose;
		}

		public Memory<byte> Memory { get; }

		public void Dispose() => _onDispose?.Invoke();
	}

	public static async ValueTask<IMemoryOwner<byte>> EncryptAsync<T>(this SymmetricAlgorithm algo, T content, JsonSerializerOptions? options = null, CancellationToken cancellationToken = default)
	{
		// Create a CryptoStream that writes to a new byte array
		using var encryptedStream = new MemoryStream();
		using var cs = new CryptoStream(encryptedStream, algo.CreateEncryptor(), CryptoStreamMode.Write);
		// Serialize the content to JSON and write it to the CryptoStream
		await JsonSerializer.SerializeAsync(cs, content, options, cancellationToken);

		// Flush the CryptoStream to ensure all data is written
		await cs.FlushFinalBlockAsync(cancellationToken);

		// Return the encrypted data
		var len = encryptedStream.Length;
		if (len > int.MaxValue)
			return new FakeMemoryOwner(encryptedStream.ToArray());

		var iLen = (int)encryptedStream.Length;
		var mo = MemoryPool<byte>.Shared.Rent(iLen);
		var buffer = mo.Memory;
		await encryptedStream.ReadAsync(buffer, cancellationToken);
		return new FakeMemoryOwner(mo.Memory[..iLen], mo.Dispose);
	}

	public static async ValueTask<T?> DecryptAsync<T>(this SymmetricAlgorithm algo, Stream encryptedData, JsonSerializerOptions? options = null, CancellationToken cancellationToken = default)
	{
		// Create a CryptoStream that reads from the encrypted data
		using var cs = new CryptoStream(encryptedData, algo.CreateDecryptor(), CryptoStreamMode.Read);
		// Deserialize the JSON from the CryptoStream and return the result
		return await JsonSerializer.DeserializeAsync<T>(cs, options, cancellationToken);
	}

	public static async ValueTask<T?> DecryptAsync<T>(this SymmetricAlgorithm algo, byte[] encryptedData, JsonSerializerOptions? options = null, CancellationToken cancellationToken = default)
	{
		using var encryptedStream = new MemoryStream(encryptedData);
		return await algo.DecryptAsync<T>(encryptedStream, options, cancellationToken);
	}

	public static async ValueTask<T?> DecryptAsync<T>(this SymmetricAlgorithm algo, ReadOnlyMemory<byte> encryptedData, JsonSerializerOptions? options = null, CancellationToken cancellationToken = default)
	{
		using var encryptedStream = new MemoryStream(encryptedData.Length);
		await encryptedStream.WriteAsync(encryptedData, cancellationToken);
		return await algo.DecryptAsync<T>(encryptedStream, options, cancellationToken);
	}
}

using System;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Xunit;

namespace PerformanceExperiments.Tests;
public class ExampleData
{
	public int Id { get; set; }
	public string? Name { get; set; }
}


public class SymmetricEncryptionTests
{
	[Fact]
	public async Task TestEncryptionAndDecryption()
	{
		var aes = Aes.Create();
		aes.GenerateKey();
		aes.GenerateIV();
		aes.Mode= CipherMode.CBC;

		var data = new ExampleData { Id = 123, Name = "John Doe" };

		// Encrypt and serialize the data
		var encryptedData = await aes.EncryptAsync(data);

		// Decrypt and deserialize the data
		var decryptedData = await aes.DecryptAsync<ExampleData>(encryptedData);

		Assert.NotNull(encryptedData);
		Assert.Equal(data.Id, decryptedData!.Id);
		Assert.Equal(data.Name, decryptedData.Name);
	}

}

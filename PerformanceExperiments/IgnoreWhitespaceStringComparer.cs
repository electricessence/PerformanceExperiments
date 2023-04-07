using System;
using System.Collections.Generic;

namespace Sylvan;

public sealed class IgnoreWhitespaceStringComparer : IEqualityComparer<string?>
{
	public static readonly IEqualityComparer<string?> Instance = new IgnoreWhitespaceStringComparer(0);
	public static readonly IEqualityComparer<string?> IgnoreCase = new IgnoreWhitespaceStringComparer(0x20);

	private IgnoreWhitespaceStringComparer(int caseMask)
	{
		this.caseMask = caseMask;
	}

	readonly int caseMask;

	public bool Equals(string? x, string? y)
	{
		if (x is null)
		{
			return y is null;
		}
		else
		{
			if (y is null)
				return false;
		}

		var xi = 0;
		var yi = 0;
		var xl = x.Length;
		var yl = y.Length;
		while (true)
		{
			var xc = -1;
			var yc = -1;
			while (xi < xl)
			{
				var c = x[xi++];
				if (!char.IsWhiteSpace(c))
				{
					xc = c;
					break;
				}
			}
			while (yi < yl)
			{
				var c = y[yi++];
				if (!char.IsWhiteSpace(c))
				{
					yc = c;
					break;
				}
			}

			if ((xc | caseMask) != (yc | caseMask))
				return false;

			if (xc == -1 && yc == -1)
				break;
		}
		return true;
	}

	public int GetHashCode(string obj)
	{
		if (obj is null) return 0;

		var hc = new HashCode();
		for (int i = 0; i < obj.Length; i++)
		{
			var c = obj[i];
			if (!char.IsWhiteSpace(c))
			{
				hc.Add(c);
			}
		}
		return hc.ToHashCode();
	}
}
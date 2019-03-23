using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Settings;
using System.Text.RegularExpressions;
using System;

namespace Submission {
/// <summary>Array distinct elements question.</summary>
[PexClass(typeof(Question))]
    public partial class Question
{
	/// <summary>Return the count of distinct values in the array.</summary>
	/// <remarks>
	/// Return the count of distinct values in the array.
	/// A value is distinct if it is different from every other value in the array.
	/// As examples:
	/// [0, 1, 2] has 3 distinct values
	/// [0, 1, 0] has 2 distinct values
	/// [0, 0, 0, 0] has 1 distinct value
	/// [5] has 1 distinct value
	/// [] has 0 distinct values
	/// Note that you may use the Java array utility class or maps to solve this problem.
	/// </remarks>
	/// <param name="array">array to search for distinct values</param>
	/// <returns>the count of distinct values in the array</returns>
    [PexMethod(TestEmissionFilter = PexTestEmissionFilter.All, MaxRuns = 60)]
	public static int countDistinct(int[] array)
	{
		int counter = 0;
		if (array == null)
		{
			return 0;
		}
		if (array.Length < 2)
		{
			return 0;
		}
		for (int i = 0; i < array.Length; i++)
		{
			for (int j = 0; j < array.Length; j++)
			{
				if (array[i] != array[j])
				{
					counter++;
					break;
				}
			}
		}
		return counter;
	}
}
}

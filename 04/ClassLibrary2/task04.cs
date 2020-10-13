using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
	public static class DoubleExtensions //сравнение с дельтой
	{
		public static bool EqualTo(this double value1, double value2, double epsilon)
		{
			return Math.Abs(value1 - value2) < epsilon;
		}
	}

	public class task04
	{

		public static int MaxElementFinding(int[] arr)
		{
			return Search(arr, 0, arr[0]);
		}

		static int Search(int[] arr, int i, int MaxEl)
		{
			if (i < arr.Length)
			{
				if (arr[i] > MaxEl)
				{
					MaxEl = arr[i];
					return Search(arr, i, MaxEl);
				}
				return Search(arr, ++i, MaxEl);

			}
			else return MaxEl;
		}

		public static int FindingElementIndexBetweenEqualSums(double[] a)
		{
			for (int i = 0; i < a.Length; i++)
			{
				int s = Summ(a, i);
				if (s != -1)
					return s;
			}
			return -1;
		}

		static int Summ(double[] arr, int pos)
		{
			double left_sum = 0;
			double right_sum = 0;

			//left
			for (int i = 0; i < pos; i++)
			{
				left_sum += arr[i];
			}
			//right
			for (int i = pos + 1; i < arr.Length; i++)
			{
				right_sum += arr[i];
			}

			if (left_sum.EqualTo(right_sum, 0.0001))
				return pos;
			else return -1;
		}

		public static string StringConcatenation(string firstStr, string secondStr)
		{
			string final = firstStr;
			for (int i = 0; i < secondStr.Length; i++)
			{
				if (!firstStr.Contains(secondStr[i]))
				{
					final += secondStr[i];
				}
			}

			return final;
		}

		public static int FindNextBiggerNumber(int s)
		{
			//split
			int tmp = s;
			int k = 0;
			bool fl = false;
			List<int> split = new List<int>();
			while (tmp > 0)
			{
				split.Add(tmp % 10);
				tmp /= 10;
				k++;
			}

			for (int i = 0; i < k - 1; i++)//убывающий порядок?
			{
				if (split[i] > split[i + 1] && !fl)
				{
					continue;
				}
				else
				{
					fl = true;
					break;
				}
			}

			if (!fl)
			{
				string tmp1 = "";
				for (int i = 0; i < k; i++)
				{
					tmp1 += split[i];
				}
				return Int32.Parse(tmp1);
			}

			fl = false;

			for (int i = 0; i < k - 1; i++)//не убывающий порядок?
			{
				if (split[i] < split[i + 1] && !fl)
				{
					continue;
				}
				else
				{
					fl = true;
					break;
				}
			}

			if (!fl)
			{
				return -1;
			}


			//3 случай, своп в середине
			int first = -1;
			int last = -1;

			for (int i = 0; i < k - 1; i++)
			{
				if (split[i] > split[i + 1])
				{
					first = i + 1;
					break;
				}
			}

			if (first == -1)
				return -1;
			int min = -1;
			for (int i = 0; i < first; i++)
			{
				
				if (min < split[i] && split[i] > split[first])
				{
					min = split[i];
					last = i;
				}
			}

			int swap = split[first];
			split[first] = split[last];
			split[last] = swap;

			for (int i = 0; i <= last; i++)
			{
				for (int j = 0; j <= last; j++)
				{
					if (split[i] > split[j])
					{
						int tt = split[i];
						split[i] = split[j];
						split[j] = tt;
					}
				}
			}
			

			string tmp2 = "";

			for (int i = k - 1; i > -1; i--)
			{
				tmp2 += split[i];
			}

			return Convert.ToInt32(tmp2);

		}
		public static int[] DigitFiltering(int[] sourceArray, int digit)
		{
			List<int> filter = new List<int>();
			for(int i = 0; i < sourceArray.Length; i++)
			{
				if(Convert.ToString(sourceArray[i]).Contains(Convert.ToString(digit)))
				{
					filter.Add(sourceArray[i]);
				}
			}

			return filter.ToArray();

		}

	}
}

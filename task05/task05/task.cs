using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05
{
    public class task
    {
        public double FindNthRoot(double a, int n, double eps)
		{
            double x0 = a / n;

            while(true)
			{
                double x1 = ((n - 1) * x0 + a / (Math.Pow(x0, n - 1))) / n;
                if (Math.Abs(x1 - x0) < eps) break;
                x0 = x1;
			}

            return Math.Round(x0, 3);
		}


        //how == 1 в порядке возрастания сумм элементов строк матрицы
        //how == -1 в порядке убывания сумм элементов строк матрицы
        //how == 2 в порядке возрастания максимальных элементов строк матрицы
        //how == -2 в порядке убывания максимальных элементов строк матрицы
        //how == 3 в порядке возрастания минимальных элементов строк матрицы
        //how == -3 в порядке убывания минимальных элементов строк матрицы
        public int[][] BubbleSort(int[][] source, int how)
		{
            if (Math.Abs(how) == 1)
            {
                int[] sum = new int[source.Length];
                
                for(int i = 0; i < source.Length; i++)
				{
                    for(int j = 0; j < source[0].Length; j++)
					{
                        sum[i] += source[i][j];
					}
				}

                for(int i = 0; i < source.Length; i++)
				{
                    for(int j = i; j < source.Length; j++)
					{
                        if(how == 1)
						{
                            if(sum[i] > sum[j])
							{
                                int tmp = sum[i];
                                sum[i] = sum[j];
                                sum[j] = sum[i];

                                int[] tmp1 = source[i];
                                source[i] = source[j];
                                source[j] = tmp1;
							}
						}
                        else
						{
                            if (sum[i] < sum[j])
                            {
                                int tmp = sum[i];
                                sum[i] = sum[j];
                                sum[j] = tmp;

                                int[] tmp1 = source[i];
                                source[i] = source[j];
                                source[j] = tmp1;
                            }
                        }
					}
				}
            }
            else if (Math.Abs(how) == 2)
			{
                int[] max = new int[source.Length];
                for(int i = 0; i < source.Length; i++)
				{
                    max[i] = source[i].Max();
				}

                for (int i = 0; i < source.Length; i++)
                {
                    for (int j = i; j < source.Length; j++)
                    {
                        if (how == 2)
                        {
                            if (max[i] > max[j])
                            {
                                int tmp = max[i];
                                max[i] = max[j];
                                max[j] = tmp;

                                int[] tmp1 = source[i];
                                source[i] = source[j];
                                source[j] = tmp1;
                            }
                        }
                        else
                        {
                            if (max[i] < max[j])
                            {
                                int tmp = max[i];
                                max[i] = max[j];
                                max[j] = tmp;

                                int[] tmp1 = source[i];
                                source[i] = source[j];
                                source[j] = tmp1;
                            }
                        }
                    }
                }
            }
			else if (Math.Abs(how) == 3)
			{
                int[] max = new int[source.Length];
                for (int i = 0; i < source.Length; i++)
                {
                    max[i] = source[i].Min();
                }

                for (int i = 0; i < source.Length; i++)
                {
                    for (int j = i; j < source.Length; j++)
                    {
                        if (how == 3)
                        {
                            if (max[i] > max[j])
                            {
                                int tmp = max[i];
                                max[i] = max[j];
                                max[j] = max[i];

                                int[] tmp1 = source[i];
                                source[i] = source[j];
                                source[j] = tmp1;
                            }
                        }
                        else
                        {
                            if (max[i] < max[j])
                            {
                                int tmp = max[i];
                                max[i] = max[j];
                                max[j] = max[i];

                                int[] tmp1 = source[i];
                                source[i] = source[j];
                                source[j] = tmp1;
                            }
                        }
                    }
                }
            }

            return source;
        }
    }
}

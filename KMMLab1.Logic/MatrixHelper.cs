using System;

namespace KMMLab1.Infrastructure
{
    internal static class MatrixHelper
    {
        //this method determines the value of determinant using recursion.
        public static double GetDeterminant(this double[,] input)
        {
            int order = int.Parse(Math.Sqrt(input.Length).ToString());
            if (order > 2)
            {
                double value = 0;
                for (int j = 0; j < order; j++)
                {
                    var tempMatrix = CreateSmallerMatrix(input, 0, j);
                    value = value + input[0, j] * (SignOfElement(0, j) * GetDeterminant(tempMatrix));
                }
                return value;
            }
            else if (order == 2)
            {
                return ((input[0, 0] * input[1, 1]) - (input[1, 0] * input[0, 1]));
            }
            else
            {
                return (input[0, 0]);
            }
        }

        public static double[,] GetEqualMatrix(this double[,] matrix)
        {
            return (double[,])matrix.Clone();
        }

        public static double[] GetEqualVector(this double[] vector)
        {
            return (double[])vector.Clone();
        }

        public static void IterateMatrix(this double[,] matrix, Action<int, int> onIterationAction)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    onIterationAction?.Invoke(i, j);
                }
            }
        }

        //this method determines the sign of the elements
        static int SignOfElement(int i, int j)
        {
            if ((i + j) % 2 == 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        //this method determines the sub matrix corresponding to a given element
        static double[,] CreateSmallerMatrix(double[,] input, int i, int j)
        {
            int order = int.Parse(Math.Sqrt(input.Length).ToString());
            var output = new double[order - 1, order - 1];
            int x = 0, y = 0;
            for (int m = 0; m < order; m++, x++)
            {
                if (m != i)
                {
                    y = 0;
                    for (int n = 0; n < order; n++)
                    {
                        if (n != j)
                        {
                            output[x, y] = input[m, n];
                            y++;
                        }
                    }
                }
                else
                {
                    x--;
                }
            }
            return output;
        }
    }
}

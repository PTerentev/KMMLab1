using System;
using System.Linq;

namespace KMMLab1.Infrastructure
{
    public class SimpleIteratorAlgorithm : ILinearAlgorithm
    {
        public virtual string Name => "Simple iterator";

        public virtual bool TrySolve(double[,] aMatrix, double[] dVector, out double[] xVector, decimal accuracy)
        {
            xVector = new double[dVector.Length]; 

            var be = GetBMatrixAndEVector(aMatrix, dVector);
            var bMatrix = be.Item1;
            var eVector = be.Item2;

            var cMax = GetCMax(bMatrix);
            if (cMax > 1)
            {
                return false;
            }

            var k = GetIterationCount(accuracy, cMax, eVector);
            xVector = GetIterationResult(eVector, bMatrix, k);
            return true;
        }

        protected double[] GetIterationResult(double[] eVector, double[,] bMatrix, int iterationCount)
        {
            double[] xVector = eVector.GetEqualVector();

            for (int i = 0; i < iterationCount; i++)
            {
                xVector = IterateXVector(eVector, xVector, bMatrix);
            }

            return xVector;
        }

        protected virtual double[] IterateXVector(double[] eVector, double[] xVector, double[,] bMatrix)
        {
            var newXVector = xVector.GetEqualVector();

            for (int i = 0; i < bMatrix.GetLength(0); i++)
            {
                double v = default;
                for (int j = 0; j < bMatrix.GetLength(1); j++)
                {
                    v += bMatrix[i, j] * xVector[j];
                }

                newXVector[i] = eVector[i] + v;
            }
            return newXVector;
        }

        protected int GetIterationCount(decimal accuracy, double cMax, double[] eVector)
        {
            var eMax = GetEMax(eVector);

            var notProceedK = (1 / Math.Log10(cMax)) * (Math.Log10(eMax) - Math.Log10(Convert.ToDouble(accuracy)) - Math.Log10(1 - cMax));

            return Convert.ToInt32(Math.Floor(Math.Abs(notProceedK))) + 1;
        }

        protected double GetEMax(double[] eVector)
        {
            return eVector.Max(d => Math.Abs(d));
        }

        protected (double[,], double[]) GetBMatrixAndEVector(double[,] aMatrix, double[] dVector)
        {
            var bMatrix = aMatrix.GetEqualMatrix();
            var eVector = dVector.GetEqualVector();

            for (int i = 0; i < aMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < aMatrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        bMatrix[i, j] = 0;
                        eVector[i] = dVector[i] / aMatrix[i, j];
                    }
                    else
                    {
                        bMatrix[i, j] = -1 * (aMatrix[i, j] / aMatrix[i, i]);
                    }
                }
            }

            return (bMatrix, eVector);
        }

        protected virtual double GetCMax(double[,] bMatrix)
        {
            var cVector = new double[bMatrix.GetLength(0)];

            for (int i = 0; i < bMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < bMatrix.GetLength(1); j++)
                {
                    cVector[i] += Math.Abs(bMatrix[i, j]);
                }
            }

            return cVector.Max();
        }
    }
}

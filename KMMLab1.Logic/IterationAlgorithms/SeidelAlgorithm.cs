using System;
using System.Linq;

namespace KMMLab1.Infrastructure
{
    public class SeidelAlgorithm : SimpleIteratorAlgorithm
    {
        public override string Name => "Seidel algorithm";

        public override bool TrySolve(double[,] aMatrix, double[] dVector, out double[] xVector, decimal accuracy)
        {
            xVector = new double[dVector.Length];

            var cMax = GetCMax(aMatrix);
            if (cMax > 1)
            {
                return false;
            }

            var be = GetBMatrixAndEVector(aMatrix, dVector);
            var bMatrix = be.Item1;
            var eVector = be.Item2;

            var k = GetIterationCount(accuracy, cMax, eVector);
            xVector = GetIterationResult(eVector, bMatrix, k);
            return true;
        }

        protected override double[] IterateXVector(double[] eVector, double[] xVector, double[,] bMatrix)
        {
            var newXVector = xVector.GetEqualVector();

            for (int i = 0; i < bMatrix.GetLength(0); i++)
            {
                double v = default;
                for (int j = 0; j < bMatrix.GetLength(1); j++)
                {
                    v += bMatrix[i, j] * newXVector[j];
                }

                newXVector[i] = eVector[i] + v;
            }
            return newXVector;
        }

        protected override double GetCMax(double[,] bMatrix)
        {
            var cVector = new double[bMatrix.GetLength(0)];

            for (int i = 0; i < bMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < bMatrix.GetLength(1); j++)
                {
                    if (i != j)
                    {
                        cVector[i] += Math.Abs(bMatrix[i, j]) / Math.Abs(bMatrix[i, i]);
                    }
                }
            }

            return cVector.Max();
        }
    }
}

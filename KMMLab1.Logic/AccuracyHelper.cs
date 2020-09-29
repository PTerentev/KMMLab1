namespace KMMLab1.Infrastructure
{
    public static class AccuracyHelper
    {
        public static AccuracyResult CalcAccuracy(double[,] aMatrix, double[] dVector, double[] xVector)
        {
            var eps = new double[dVector.Length];

            for (int i = 0; i < aMatrix.GetLength(0); i++)
            {
                eps[i] -= dVector[i];
                for (int j = 0; j < aMatrix.GetLength(1); j++)
                {
                    eps[i] += aMatrix[i, j] * xVector[j];
                }
            }

            var bValues = (double[])eps.Clone();

            for (int i = 0; i < bValues.Length; i++)
            {
                bValues[i] += dVector[i];
            }

            return new AccuracyResult()
            {
                BValues = bValues,
                Epsilons = eps
            };
        }
    }
}

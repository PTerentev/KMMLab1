namespace KMMLab1.Infrastructure
{
    public class KramerAlgorithm : ILinearAlgorithm
    {
        public string Name => "Kramer algorithm";

        public bool TrySolve(double[,] aMatrix, double[] dVector, out double[] xVector, decimal accuracy = default)
        {
            xVector = new double[dVector.Length];

            var determinant = aMatrix.GetDeterminant();

            if (determinant == 0)
            {
                return false;
            }

            for (int i = 0; i < dVector.Length; i++)
            {
                var newMatrix = ChangeColumnValue(i, aMatrix, dVector);
                xVector[i] = newMatrix.GetDeterminant() / determinant;
            }

            return true;
        }

        private double[,] ChangeColumnValue(int columnNumber, double[,] matrix, double[] newValues)
        {
            var newMatrix = matrix.GetEqualMatrix();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                newMatrix[i, columnNumber] = newValues[i];
            }

            return newMatrix;
        }
    }
}

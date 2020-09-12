namespace KMMLab1.Infrastructure
{
    public interface ILinearAlgorithm
    {
        string Name { get; }
        bool TrySolve(double[,] aMatrix, double[] dVector, out double[] xVector, decimal accuracy = default);
    }
}

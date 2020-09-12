using System;

namespace KMMLab1.Infrastructure
{
    public class GaussAlgorithm : ILinearAlgorithm
    {
        private double[,] aMatrix;  // матрица A
        private double[] xVector;   // вектор неизвестных x
        private double[] dVector;   // вектор b
        private int size;            // размерность задачи
        public string Name => "Gauss algorithm";

        public bool TrySolve(double[,] aMatrix, double[] dVector, out double[] xVector, decimal accuracy = default)
        {
            int dLength = dVector.Length;
            int aLength = aMatrix.Length;
            this.size = dLength;
            this.aMatrix = aMatrix.GetEqualMatrix();
            this.dVector = dVector.GetEqualVector();  // с его копией будем производить вычисления
            this.xVector = xVector = new double[size];       

            GaussSolve();
            return true;
        }

        // инициализация массива индексов столбцов
        private int[] InitIndex()
        {
            int[] index = new int[size];
            for (int i = 0; i < index.Length; ++i)
            {
                index[i] = i;
            }
            return index;
        }

        // поиск главного элемента в матрице
        private double FindR(int row, int[] index)
        {
            int max_index = row;
            double max = aMatrix[row, index[max_index]];
            double max_abs = Math.Abs(max);

            for (int cur_index = row + 1; cur_index < size; ++cur_index)
            {
                double cur = aMatrix[row, index[cur_index]];
                double cur_abs = Math.Abs(cur);
                if (cur_abs > max_abs)
                {
                    max_index = cur_index;
                    max = cur;
                    max_abs = cur_abs;
                }
            }

            // меняем местами индексы столбцов
            int temp = index[row];
            index[row] = index[max_index];
            index[max_index] = temp;

            return max;
        }

        // Нахождение решения СЛУ методом Гаусса
        private void GaussSolve()
        {
            int[] index = InitIndex();
            GaussForwardStroke(index);
            GaussBackwardStroke(index);
        }

        // Прямой ход метода Гаусса
        private void GaussForwardStroke(int[] index)
        {
            // перемещаемся по каждой строке сверху вниз
            for (int i = 0; i < size; ++i)
            {
                // 1) выбор главного элемента
                double r = FindR(i, index);

                // 2) преобразование текущей строки матрицы A
                for (int j = 0; j < size; ++j)
                {
                    aMatrix[i, j] /= r;
                }

                // 3) преобразование i-го элемента вектора b
                dVector[i] /= r;

                // 4) Вычитание текущей строки из всех нижерасположенных строк
                for (int k = i + 1; k < size; ++k)
                {
                    double p = aMatrix[k, index[i]];
                    for (int j = i; j < size; ++j)
                    {
                        aMatrix[k, index[j]] -= aMatrix[i, index[j]] * p;
                    }
                    dVector[k] -= dVector[i] * p;
                    aMatrix[k, index[i]] = default;
                }
            }
        }

        // Обратный ход метода Гаусса
        private void GaussBackwardStroke(int[] index)
        {
            // перемещаемся по каждой строке снизу вверх
            for (int i = size - 1; i >= 0; --i)
            {
                // 1) задаётся начальное значение элемента x
                double x_i = dVector[i];

                // 2) корректировка этого значения
                for (int j = i + 1; j < size; ++j)
                {
                    x_i -= xVector[index[j]] * aMatrix[i, index[j]];
                }
                xVector[index[i]] = x_i;
            }
        }
    }
}

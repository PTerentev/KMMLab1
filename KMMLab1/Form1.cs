using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using KMMLab1.Infrastructure;

namespace KMMLab1
{
    public partial class Form1 : Form
    {
        private int count = 4;
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeAMatrixGrid()
        {
            for (int i = 0; i < count; i++)
            {
                aMatrixDataGridView.Columns.Add((i + 1).ToString(), "");
                if (i == 0)
                {
                    for (int j = 0; j < count; j++)
                    {
                        aMatrixDataGridView.Rows.Add();
                    }
                }

            }
        }

        private void InitializeDMatrixGrid()
        {
            dMatrixDataGridView.Columns.Add("D", "");
            for (int i = 0; i < count; i++)
            {
                dMatrixDataGridView.Rows.Add();
            }
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            double[,] aMatrix;
            double[] dVector;
            decimal accuracy;

            try
            {
                aMatrix = GetAMatrix();
                dVector = GetDVector();
                accuracy = Convert.ToDecimal(accuracyTextBox.Text, CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error in inputed data! {ex.Message}");
                return;
            }

            // For tests.
            //var aMatrix = new double[3, 3]
            //{
            //    {8, -1, 2},
            //    {1, 9, 3},
            //    {2, -3, 10},
            //};

            //var dVector = new double[3]
            //{
            //    8, 18, -5
            //};

            //var accuracy = 0.05m;

            var outputBuilder = new StringBuilder();
            foreach(var alg in GetLinearAlgorithms())
            {
                var outputAlg = $"{alg.Name}: ";
                try
                {
                    if (alg.TrySolve(aMatrix, dVector, out var xVector, accuracy))
                    {
                        outputAlg += GetStringOfXVector(xVector);
                    }
                    else
                    {
                        outputAlg += "could not solve it!";
                    }
                }
                catch (Exception ex)
                {
                    outputAlg += $"an error occurred in solving! {ex.Message}";
                }

                outputBuilder.AppendLine(outputAlg);
            }

            outputTextBox.Text = outputBuilder.ToString();
        }

        private string GetStringOfXVector(double[] xVector)
        {
            var builder = new StringBuilder();

            for (int i = 0; i < xVector.Length; i++)
            {
                builder.Append($"x{i} = {xVector[i]:0.00000}; ");
            }

            return builder.ToString();
        }

        private IEnumerable<ILinearAlgorithm> GetLinearAlgorithms()
        {
            var types = Assembly.GetAssembly(typeof(ILinearAlgorithm)).GetTypes();

            return types
                .Where(t => typeof(ILinearAlgorithm).IsAssignableFrom(t) && !t.IsInterface)
                .Select(t => (ILinearAlgorithm)Activator.CreateInstance(t));
        }

        private double[,] GetAMatrix()
        {
            var matrix = new double[count, count];
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    matrix[i, j] = Convert.ToDouble(aMatrixDataGridView[j, i].Value, CultureInfo.InvariantCulture);
                }
            }

            return matrix;
        }

        private double[] GetDVector()
        {
            var matrix = new double[count];
            for (int i = 0; i < count; i++)
            {
                matrix[i] = Convert.ToDouble(dMatrixDataGridView[0, i].Value, CultureInfo.InvariantCulture);
            }

            return matrix;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count = Convert.ToInt32(xCountBox.Text);
            InitializeAMatrixGrid();
            InitializeDMatrixGrid();
            button1.Enabled = false;
            xCountBox.Enabled = false;
            calcButton.Enabled = true;
        }
    }
}

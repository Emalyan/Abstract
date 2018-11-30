using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{

    internal abstract class Actions : Matrix
    {
        public Actions(int countOfColumn, int countOfRow) : base(countOfColumn, countOfRow)
        {
        }

        public static int row;
        public static int column;
        public static Matrix matrixOne;
        public static Matrix matrixTwo;

        public static void ShowMatrix(Matrix matrix)
        {
            for (int i = 0; i < matrix.Value.Length; i++)
            {
                for (int j = 0; j < matrix.Value[i].Length; j++)
                {
                    Console.Write(string.Format("{0:F1}", matrix.Value[i][j]) + "\t");
                }
                Console.WriteLine();
            }
        }

        private static void InitializerVariables()
        {
            column = SetVariableSize("колонок");
            row = SetVariableSize("строк");
        }

        public static int SetVariableSize(string variableName)
        {
            int variable = 0;
            Console.Write($"Введите количество {variableName}: ");
            variable = int.Parse(Console.ReadLine());
            return variable;
        }       

        public static Matrix CreateMatrix()
        {
            return new Matrix(column, row);
        }

        public static Matrix AddMatrix()
        {
            InitializerVariables();
            Matrix matrix = CreateMatrix();
            Console.WriteLine("Задайте значения матрицы:");
            for (int i = 0; i < matrix.Value.Length; i++)
            {
                for (int j = 0; j < matrix.Value[i].Length; j++)
                {
                    Console.Write("Число: ");
                    matrix.Value[i][j] = decimal.Parse(Console.ReadLine());
                }
            }
            return matrix;
        }

        public static void AdditionTwoMatrix()
        {
            matrixOne = AddMatrix();
            Console.WriteLine("Матрица 1: ");
            ShowMatrix(matrixOne);
            matrixTwo = AddMatrix();
            Console.WriteLine("Матрица 2: ");
            ShowMatrix(matrixTwo);
        }


    }
}

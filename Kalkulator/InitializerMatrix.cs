using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    

    internal class InitializerMatrix : Actions
    {       
        public InitializerMatrix(int countOfColumn, int countOfRow) : base(countOfColumn, countOfRow)
        {
        }
        
        public static void Choice()
        {
            Console.Write("Введите действие: ");
            string selection = Console.ReadLine();
            switch (selection)
            {                
                case "+":
                    AdditionTwoMatrix();
                    Matrix matrixSum = matrixOne + matrixTwo;
                    Console.WriteLine("Сумма первой и второй матрицы: ");
                    ShowMatrix(matrixSum);
                    break;

                case "*":
                    AdditionTwoMatrix();
                    Matrix matrixMult = matrixOne * matrixTwo;
                    Console.WriteLine("Умножение первой и второй матрицы равно: ");
                    ShowMatrix(matrixMult);
                    break;

                case "-":
                    AdditionTwoMatrix();
                    Matrix matrixDifference = matrixOne - matrixTwo;
                    Console.WriteLine("Разность первой и второй матрицы: ");
                    ShowMatrix(matrixDifference);
                    break;

                case "/":
                    AdditionTwoMatrix();
                    Matrix matrixShare = matrixOne / matrixTwo;
                    Console.WriteLine("Деление первой и второй матрицы: ");
                    ShowMatrix(matrixShare);
                    break;

                case "T":
                    matrixOne = AddMatrix();
                    Console.WriteLine("Матрица: ");
                    ShowMatrix(matrixOne);
                    Console.WriteLine("Транспорированая матрица");
                    Matrix matrixTrans = matrixOne.Transport();
                    ShowMatrix(matrixTrans);
                    break;
                default:
                    Console.WriteLine("Не корректный ввод");
                    break;


            }
        }


    }
}

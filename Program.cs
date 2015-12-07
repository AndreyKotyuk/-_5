using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static void form_matrix(int[,] a,int size) //функция формирования пустой матрицы
        {
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    a[i, j] = 0;
        }
        static void output_matrix(int[,] a, int strings, int columns)
        {
            for (int i = 0; i < strings; i++)
            {
                for (int j = 0; j < columns; j++)
                    Console.Write(a[i, j] + " ");
                Console.WriteLine();
            }
        }//функция вывода матрицы на экран
        static int input_matrix(int[,] a)//функция заполнения матрицы смежности по варианту
        {
            //Мой граф
            //a[0, 1] = 1;
            //a[0, 5] = 1;
            //a[0, 7] = 1;
            //a[1, 2] = 1;
            //a[1, 0] = 1;
            //a[2, 1] = 1;
            //a[2, 7] = 1;
            //a[3, 6] = 1;
            //a[3, 5] = 1;
            //a[4, 5] = 1;
            //a[5, 0] = 1;
            //a[5, 3] = 1;
            //a[5, 4] = 1;
            //a[5, 6] = 1;
            //a[5, 7] = 1;
            //a[6, 3] = 1;
            //a[6, 5] = 1;
            //a[6, 7] = 1;
            //a[7, 0] = 1;
            //a[7, 2] = 1;
            //a[7, 5] = 1;
            //a[7, 6] = 1;
            int x;
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("введите координаты точек выходящих из точки " + (i + 1));
                do
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    if (x == -1)
                        break;
                    a[i, x - 1] = 1;
                }
                while (true);
            }
            return 0;
        }

        static void Main(string[] args)
        {
            int size = 8;
            int[,] a = new int[size, size];
            int[] z = new int[size];
            form_matrix(a,size);
            input_matrix(a);
            output_matrix(a, size, size);
     
            int []col= new int [size]; 
 for(int i = 0; i < size; ++i) 
 col[i] = 1; 
 for(int i = 0; i < size; ++i) 
 for(int j = i + 1; j < size - 1; ++j) 
 if(a[i,j] == 1 && col[j] == col[i]) 
 col[j] = col[i] + 1; 
 int max = col[0]; 
 for(int j = 1; j < size; ++j) 
 if(max < col[j]) 
 max = col[j];
 Console.Write("\n");
 Console.WriteLine("\nХроматическое число графа равно "+max);
            Console.ReadKey();
        }
    }
}

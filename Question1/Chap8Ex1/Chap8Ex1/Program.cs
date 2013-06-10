using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap8Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 3;
            int cols = 6;


        int[,] num = new int[rows,cols];

        for (int i = 0; i <rows ;i++ )
        {

            for (int j = 0; j < cols;j++ )
            {

                Console.Write("Enter the number: ");
                num[i,j] =int.Parse(Console.ReadLine());

            }

           
        }
        
            int[] num2 = new int[num.Length];

            
        for (int i = 0; i < rows; i++)
        {

            Console.WriteLine("");
            
            for (int j = 0; j < cols; j++)
            {
                
                num2[j+i*cols] =num[i,j];
                Console.Write(" " +num[i,j]);

            }

           
        }


        for (int i = 0; i < num.Length; i++)
        {

            Console.WriteLine(num2[i]);

        }

        }
    }
}

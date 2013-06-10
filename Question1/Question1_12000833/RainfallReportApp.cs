using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Question1_12000833
{
    class RainfallReportApp
    {
        static void Main(string[] args)
        {
            //Mogamat Tariq Patel 12000833 PROG6211 assignment1 question1
            // initialising main variables and arrays
            int numberOfTowns;
            String[] getTowns;
            int[,] getRainFall;
            double[] averagePerTown;
            double highestAverage;
            double lowestAverage;

            //calling methods in main method
            numberOfTowns = GetNumberOfTowns();
            getTowns = GetTowns(numberOfTowns);
            getRainFall = GetRainfall(getTowns);
            averagePerTown = CalculateAveragePerTown(getRainFall, numberOfTowns);
            highestAverage = FindHighest(averagePerTown);
            lowestAverage = FindLowest(averagePerTown);

            GenerateRainFallReport(getTowns, getRainFall, averagePerTown, highestAverage, lowestAverage);
        }

        //The method to get number of towns
        static int GetNumberOfTowns()
        {
            int numbTowns = 0;
            
            bool condition = false;

            while (condition==false)
            {
                Console.Write("Please enter the number of towns (1-10): ");
                numbTowns = int.Parse(Console.ReadLine());
                if (numbTowns < 1 || numbTowns > 10)
                {
                    Console.WriteLine("INCORRECT INPUT. Please enter a number between 1 and 10.");

                }
                else
                {
                    condition = true;
                }
                
            }
            Console.Clear();
            return numbTowns;
        }
         
        // Code to enter the names of the towns into a sorted array
        static String[] GetTowns(int numbTowns)
        {
            String[] towns = new String[numbTowns];



            for (int i = 0; i < numbTowns; ++i)
            {

                Console.Write("Please enter the name of town {0}: ", i+1);
                towns[i] = Console.ReadLine();



            }
            Array.Sort(towns);
            Console.Clear();
            return towns;
        }

        //Code to get rainfall per term
        static int[,] GetRainfall(String[] townNames)
        {
            int terms = 4;
            int cols = townNames.Length;
            int rows = terms;

            int[,] rain = new int[cols, rows];

            for (int i = 0; i < cols; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("Please enter the rainfall for {0} below (in mm): ", townNames[i]);

                for (int j = 0; j < rows; j++)
                {

                    Console.Write("Term {0}: ", j+1);
                    rain[i, j] = int.Parse(Console.ReadLine());

                }
            }
            Console.Clear();
            return rain;
        }

        // code to get the average of rainfall per town
        static double[] CalculateAveragePerTown(int[,] rainfall, int numbTowns)
        {
            double[] averageRainFall = new double[numbTowns];

            double terms = 4.0;
            int cols = numbTowns;
            double rows = terms;
            double average = 0;
            int sum = 0;


            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {

                    sum += rainfall[i, j];

                }
                average = sum / rows;
                Math.Round(average,2);
                averageRainFall[i] = average;
                average = sum = 0;
            }

            
            return averageRainFall;


        }
        // code to find the highest average 
        static double FindHighest(double[] average)
        {
            double currentHigh = 0.0;
            double temp;
            
            bool condition = true;
            for (int i = 0; condition == true;i++ )
            {

                for (int j = 0; j < average.Length;j++ )
                {
                    temp = Math.Max(average[i],average[j]);
                    
                    if(temp>currentHigh){
                        currentHigh = temp;
                    }

                }
                condition = false;
            }
            return currentHigh;
        }
        // code to find the lowest average
        static double FindLowest(double[] average)
        {
            double currentLowest = 999999999.0;

            
            double temp;
            bool condition = true;
            for (int i = 0; condition == true; i++)
            {

                for (int j = 0; j < average.Length; j++)
                {
                    temp = Math.Min(average[i], average[j]);

                    if (temp < currentLowest)
                    {
                        currentLowest = temp;
                    }

                }
                condition = false;
            }
            
            return currentLowest;
            
        }
        // code to generate the final report
        static void GenerateRainFallReport(string[] getTowns, int[,] getRainFall, double[] averagePerTown, double highestAverage, double lowestAverage)
        {

            Console.WriteLine("TOWN\t\t\tTERM 1\tTERM 2\tTERM 3\tTERM 4\tAVERAGE");
            Console.WriteLine("====\t\t\t======\t======\t======\t======\t=======");
            for (int i = 0; i < getTowns.Length; i++)
            {
                Console.Write("{0,-10}\t",getTowns[i]);
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("\t" + getRainFall[i,j]); 

                }
                if(averagePerTown[i] ==highestAverage){
                    Console.Write("\t{0:##.00} (+)\n", averagePerTown[i]);
                }else if(averagePerTown[i] ==lowestAverage){
                    Console.Write("\t{0:##.00} (-)\n",averagePerTown[i]);
                }else
                Console.Write("\t{0:##.00}\n",averagePerTown[i]);
            }
        }
    }
}
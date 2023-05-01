﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateCensusAnalyserProblem
{
    public class Program
    {
        static void Main(string[] args)
        {

            //StateCensusAnalyser analyser = new StateCensusAnalyser(@"C:\Users\91997\source\repos\StateCensusAnalyserProblem\Analyser.csv");
            //List<string[]> data = analyser.LoadData();
            //foreach (var item in data)
            //{
            //    Console.WriteLine(string.Join(",", item));
            //}
            //Console.ReadKey();

            //int expectedRecords = 4;
            //int actualRecords = analyser.GetNumberOfRecodrs();
            //if (expectedRecords == actualRecords)
            //{
            //    Console.WriteLine("Test case passed. Number of records match.");
            //}
            //else
            //{
            //    Console.WriteLine("Test case failed.Expected records, but got Actual records.");
            //}
            //Console.ReadKey();



            //try
            //{
            //    StateCensusAnalyser analyser = new StateCensusAnalyser(@"C:\Users\91997\source\repos\StateCensusAnalyserProblem\Analyser.csv");
            //    int expectedRecords = 4;
            //    int actualRecords = analyser.GetNumberOfRecodrs();
            //    if (actualRecords == expectedRecords)
            //    {
            //        Console.WriteLine("Test case passed. Number of records match.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Test case failed. Expected {expectedRecords} records, but got {actualRecords}.");
            //    }
            //}
            //catch (CSVFormatException e)
            //{
            //    Console.WriteLine($"Test case failed. {e.Message}");
            //}


            try
            {
                string filePath = @"C:\Users\91997\source\repos\StateCensusAnalyserProblem\Analyser.csv";
                StateCensusAnalyser analyser = new StateCensusAnalyser(filePath);
                analyser.LoadData();
            }
            catch (CensusAnalyserException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();

        }
    }
}

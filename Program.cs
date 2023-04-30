using System;
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

            StateCensusAnalyser analyser = new StateCensusAnalyser(@"C:\Users\91997\source\repos\StateCensusAnalyserProblem\Analyser.csv");
            //List<string[]> data = analyser.LoadData();
            //foreach (var item in data)
            //{
            //    Console.WriteLine(string.Join(",", item));
            //}
            //Console.ReadKey();

            int expectedRecords = 4;
            int actualRecords = analyser.GetNumberOfRecodrs();
            if (expectedRecords == actualRecords)
            {
                Console.WriteLine("Test case passed. Number of records match.");
            }
            else
            {
                Console.WriteLine("Test case failed.Expected records, but got Actual records.");
            }
            Console.ReadKey();

        }
    }
}

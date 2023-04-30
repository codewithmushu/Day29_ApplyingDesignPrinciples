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
            List<string[]> data = analyser.LoadData();
            foreach (var item in data)
            {
                Console.WriteLine(string.Join(",", item));
            }
            Console.ReadKey();

        }
    }
}

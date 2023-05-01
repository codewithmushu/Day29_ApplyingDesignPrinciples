using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateCensusAnalyserProblem
{
    public class StateCensusAnalyser
    {
        private readonly string filePath;

        public StateCensusAnalyser(string filePath)
        {
            this.filePath = filePath;
        }

        public List<string[]> LoadData()
        {
            var csvData = new CSVStateCensus();

            try
            {
                var data = csvData.GetData(filePath);
                return data.ToList();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidDataException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }
    }
    
    public class CensusAnalyserException : Exception
    {
        public CensusAnalyserException(string message) : base(message)
        {

        }
    }
}

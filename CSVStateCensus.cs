using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateCensusAnalyserProblem
{
    public class CSVStateCensus
    {
        private string filePath;
        private List<string[]> data;

        public CSVStateCensus(string filePath)
        {
            this.filePath = filePath;
            data = new List<string[]>();
        }

        public IEnumerable<string[]> GetData()
        {
            using (var reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    yield return values;
                }
            }
        }
    }
}

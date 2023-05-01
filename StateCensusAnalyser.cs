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
        public int LoadData(string filePath, char delimiter = ',')
        {
            CSVStateCensus csvData = new CSVStateCensus();
            IEnumerable<string[]> data = csvData.GetData(filePath, delimiter);
            return ((List<string[]>)data).Count;
        }
    }
  
}

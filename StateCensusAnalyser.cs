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
        private CSVStateCensus csvStateCensus;

        public StateCensusAnalyser(string filePath)
        {
            this.csvStateCensus = new CSVStateCensus();
            this.data = csvStateCensus.GetData(filePath).ToList();
        }

        public List<string[]> data { get; set; }
    }
  
}

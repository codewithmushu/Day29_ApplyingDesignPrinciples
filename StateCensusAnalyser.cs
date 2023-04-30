using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateCensusAnalyserProblem
{
    public class StateCensusAnalyser
    {
        private string filePath;

        public StateCensusAnalyser(string filePath)
        {
            this.filePath = filePath;
        }

        public List<string[]> LoadData()
        {
            CSVStateCensus csvStateCensus = new CSVStateCensus(filePath);
            var data = csvStateCensus.GetData();

            List<string[]> dataList = new List<string[]>();
            foreach (var item in data)
            {
                dataList.Add(item);
            }

            return dataList;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateCensusAnalyserProblem
{
    class CSVStates : IEnumerable
    {
        private string filename;

        public CSVStates(string filename)
        {
            this.filename = filename;
        }

        public IEnumerator GetEnumerator()
        {
            using (var reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    yield return line.Split(',');
                }
            }
        }

    }
}

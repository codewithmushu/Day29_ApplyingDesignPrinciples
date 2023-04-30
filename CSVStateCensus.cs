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
            //using (var reader = new StreamReader(filePath))
            //{
            //    while (!reader.EndOfStream)
            //    {
            //        var line = reader.ReadLine();
            //        var values = line.Split(',');

            //        yield return values;
            //    }
            //}

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"Could not find file at {filePath}");
            }

            string[] fileLines = File.ReadAllLines(filePath);
            if (fileLines.Length < 2)
            {
                throw new CSVFormatException("File does not contain enough records");
            }

           

            foreach (string line in fileLines)
            {
                var values = line.Split(',');

                if (values.Length != 3)
                {
                    throw new CSVFormatException($"Invalid number of fields in line: {line}");
                }
                data.Add(values);
                yield return values;    
            }
        }

        public List<string[]> LoadData()
        {
            data.Clear();
            foreach (string[] row in GetData())
            {
                data.Add(row);
            }
            return data;
        }
        public int GetNumberOfRecords()
        {
            return data.Count;
        }
    }

    public class CSVFormatException : Exception
    {
        public CSVFormatException(string message) : base(message)
        {
        }
    }
}

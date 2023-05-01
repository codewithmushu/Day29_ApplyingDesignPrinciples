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
        //public IEnumerable<string[]> GetData(string filePath)
        //{
        //    if (!File.Exists(filePath))
        //    {
        //        throw new FileNotFoundException("File not found!", filePath);
        //    }

        //    var lines = File.ReadAllLines(filePath);

        //    if (lines.Length <= 1)
        //    {
        //        throw new InvalidDataException("File is empty or does not contain any data.");
        //    }

        //    var header = lines[0].Split(',');

        //    // Check if the headers are valid
        //    if (!header.SequenceEqual(new string[] { "State", "Population", "AreaInSqKm", "DensityPerSqKm" }))
        //    {
        //        throw new InvalidDataException("Invalid header! Header should contain State, Population, AreaInSqKm, and DensityPerSqKm in that order.");
        //    }

        //    for (int i = 1; i < lines.Length; i++)
        //    {
        //        var values = lines[i].Split(',');

        //        // Check if the number of columns match with the header
        //        if (values.Length != header.Length)
        //        {
        //            throw new InvalidDataException($"Line {i + 1} has invalid number of columns.");
        //        }

        //        // Check if the values are of correct type
        //        if (!int.TryParse(values[1], out _) || !double.TryParse(values[2], out _) || !double.TryParse(values[3], out _))
        //        {
        //            throw new InvalidDataException($"Line {i + 1} has invalid data type.");
        //        }

        //        yield return values;
        //    }

        //}

        public IEnumerable<string[]> GetData(string filePath, char delimiter)
        {
            if (!File.Exists(filePath))
            {
                throw new CensusAnalyserException("File not found", CensusAnalyserException.ExceptionType.FILE_NOT_FOUND);
            }

            string[] lines = File.ReadAllLines(filePath);

            if (lines.Length == 0)
            {
                throw new CensusAnalyserException("File is empty", CensusAnalyserException.ExceptionType.EMPTY_FILE);
            }

            var data = new List<string[]>();

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    throw new CensusAnalyserException("Invalid line in file", CensusAnalyserException.ExceptionType.INVALID_LINE);
                }
                var values = line.Split(delimiter);

                data.Add(values);
            }

            return data;

        }
    }
     public class CensusAnalyserException : Exception
    {
        public enum ExceptionType
        {
            FILE_NOT_FOUND,
            EMPTY_FILE,
            INVALID_LINE
           
        }

        public ExceptionType type;

        public CensusAnalyserException(string message, ExceptionType type) : base(message)
        {
            this.type = type;
        }
    }
}

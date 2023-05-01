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
        public IEnumerable<string[]> GetData(string filePath, char delimiter = ',')
        {
            if (!File.Exists(filePath))
                throw new CensusAnalyserException("File not found", CensusAnalyserException.ExceptionType.FILE_NOT_FOUND);

            string[] header = null;
            using (var reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(delimiter);

                    if (header == null)
                    {
                        header = values;
                        continue;
                    }

                    if (header.Length != values.Length)
                        throw new CensusAnalyserException("Invalid header", CensusAnalyserException.ExceptionType.INVALID_HEADER);

                    yield return values;
                }
            }
        }

        public class CensusAnalyserException : Exception
        {
            public enum ExceptionType
            {
                FILE_NOT_FOUND,
                INVALID_DELIMITER,
                INVALID_HEADER
            }

            public ExceptionType exceptionType;

            public CensusAnalyserException(string message, ExceptionType exceptionType) : base(message)
            {
                this.exceptionType = exceptionType;
            }
        }

    }
}

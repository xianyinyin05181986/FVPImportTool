using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FairValueProImportTool
{
    public static class OperationLoger
    {
        private static string FilePath(string operationType)
        {
            string dateTimeUtcNowDateToString = DateTime.UtcNow.Date.ToString("yyyyMMdd");
            return String.Format("{0}-{1}{2}", operationType,dateTimeUtcNowDateToString, ".txt");
        }

        private const string STR_OPERATION_TYPE = "Rename Asset ID";
        private static void WriteWithTime(string log, string operationType)
        {
            if (!File.Exists(FilePath(operationType)))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(FilePath(operationType)))
                {
                    sw.WriteLine(log);
                }
            }

            // This text is always added, making the file longer over time
            // if it is not deleted.
            using (StreamWriter sw = File.AppendText(FilePath(operationType)))
            {
                sw.WriteLine(log);
            }


        }

        public static void WriteLogToResult(string log, string operationType = STR_OPERATION_TYPE)
        {
            WriteWithTime(String.Format("{0}--{1}", DateTime.Now.ToString("yyyyMMdd-hh:mm:ss"), log), operationType);
        }
    }
}

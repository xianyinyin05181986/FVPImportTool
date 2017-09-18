using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace FairValueProImportTool
{
    public class FileOperator
    {
        public FileOperator()
        {
            ResetCounter();
        }
        public void ResetCounter()
        {
            NumberOfCopied = 0;
            NumberOfNewFileExist = 0;
            NumberOfOldFileNotExist = 0;
            NumberOfUnknown = 0;
        }
        private int NumberOfCopied;
        private int NumberOfNewFileExist;
        private int NumberOfOldFileNotExist;
        private int NumberOfUnknown;

        public int GetNumberOfCopied
        {
            get
            {
                return NumberOfCopied;
            }
        }
        public int GetNumberOfNewFileExist
        {
            get
            {
                return NumberOfNewFileExist;
            }
        }
        public int GetNumberOfOldFileNotExist
        {
            get
            {
                return NumberOfOldFileNotExist;
            }
        }
        public int GetNumberOfUnknown
        {
            get
            {
                return NumberOfUnknown;
            }
        }
        public FileOperationCode Export(string oldpath, string newpath, bool overwritten = false)
        {
            FileOperationCode code = ExportFile(oldpath, newpath, overwritten);
            switch (code)
            {
                case FileOperationCode.Unknown:
                    NumberOfUnknown++;
                    break;
                case FileOperationCode.Copied:
                    NumberOfCopied++;
                    break;
                case FileOperationCode.Error_New_File_Exists:
                    NumberOfNewFileExist++;
                    break;
                case FileOperationCode.Error_Old_File_Not_Exists:
                    NumberOfOldFileNotExist++;
                    break;
                default:
                    NumberOfUnknown++;
                    break;
            }
            return code;
        }

        public string GetExportSummary()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}:{1}{2}", FileOperationCode.Copied, NumberOfCopied, Environment.NewLine);
            sb.AppendFormat("{0}:{1}{2}", FileOperationCode.Error_New_File_Exists, NumberOfNewFileExist, Environment.NewLine);
            sb.AppendFormat("{0}:{1}{2}", FileOperationCode.Error_Old_File_Not_Exists, NumberOfOldFileNotExist, Environment.NewLine);
            sb.AppendFormat("{0}:{1}{2}", FileOperationCode.Unknown, NumberOfUnknown, Environment.NewLine);
            return sb.ToString();
        }
        private static string GetUniqueFilename(string filepath)
        {
            if (File.Exists(filepath))
            {
                string folder = Path.GetDirectoryName(filepath);
                string filename = Path.GetFileNameWithoutExtension(filepath);
                string extension = Path.GetExtension(filepath);
                int number = 1;

                Match regex = Regex.Match(filepath, @"(.+) \((\d+)\)\.\w+");

                if (regex.Success)
                {
                    filename = regex.Groups[1].Value;
                    number = int.Parse(regex.Groups[2].Value);
                }

                do
                {
                    number++;
                    filepath = Path.Combine(folder, string.Format("{0} ({1}){2}", filename, number, extension));
                }
                while (File.Exists(filepath));
            }
            return filepath;
        }
        protected FileOperationCode ExportFile(string oldpath, string newpath, bool overwritten = false)
        {
            FileOperationCode result = FileOperationCode.Unknown;
            string newfullpath = newpath;
            if (File.Exists(newpath) && !overwritten)
            {
                result = FileOperationCode.Error_New_File_Exists;
                return result;
            }
            else
            {
                newfullpath = GetUniqueFilename(newpath);
            }
            if (!File.Exists(oldpath))
            {
                result = FileOperationCode.Error_Old_File_Not_Exists;
                return result;
            }
            try
            {
                File.Copy(oldpath, newfullpath, true);
                result = FileOperationCode.Copied;
            }
            catch (Exception)
            {
                result = FileOperationCode.Unknown;
            }
            return result;
        }
    }


    public enum FileOperationCode
    {
        Unknown,
        Copied,
        Error_New_File_Exists,
        Error_Old_File_Not_Exists

    }
}

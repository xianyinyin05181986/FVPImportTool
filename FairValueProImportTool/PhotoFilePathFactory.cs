using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FairValueProImportTool
{
    public static class PhotoFilePathFactory
    {
        private const string STR_EXTENTION = ".JPG";
        private const string STR_PREFIX = "";
        public static string GenerateFullPhotoFilePath(string folderpath,
            string filename,
            bool convertable = true)
        {
            if (convertable)
                return String.Format("{0}\\{1}", folderpath, filename);
            else
                return String.Format("{0}\\{1}{2}", folderpath, filename, STR_EXTENTION);
        }
        public static string GenerateFullPhotoFilePath(string folderpath, string filename, string prefix = STR_PREFIX, bool convertable = true)
        {
            return String.Format("{0}{1}", prefix, GenerateFullPhotoFilePath(folderpath, filename, convertable));
        }
    }
}

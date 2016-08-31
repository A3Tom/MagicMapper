namespace MagicMapperData.Classes
{
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Models;

    class FileLocator : IFileLocator
    {
        public List<FileDetail> LocateAllFiles(string filePath)
        {
            List<FileDetail> result = new List<FileDetail>();
            string fileName;
            string[] files = Directory.GetFiles(filePath, "*.cs", SearchOption.AllDirectories);
            
            foreach(string file in files)
            {
                FileDetail fileDetail = new FileDetail();
                fileDetail.FilePath = file;
                int startIndex = file.LastIndexOf('\\') + 1;
                fileName = file.Substring(startIndex, file.Length - startIndex);
                fileDetail.FileName = fileName;

                if(fileDetail.FilePath.Contains("Models"))
                {
                    fileDetail.FileType = "Model";
                }
                else
                {
                    fileDetail.FileType = "Program";
                }


                result.Add(fileDetail);
            }

            return result;
        }
    }
}

namespace MagicMapperData.Classes
{
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Models;

    class FileLocator : IFileLocator
    {
        public List<FileDetail> LocateAllFiles(string filePath, string[] fileTypes)
        {
            List<FileDetail> result = new List<FileDetail>();
            string fileName;
            string[] files = Directory.GetFiles(filePath, "*.cs", SearchOption.AllDirectories);

            foreach (string file in files)
            {
                if (!file.Contains("ENV"))
                {
                    FileDetail fileDetail = new FileDetail();
                    TypeDetails typeDetail = new TypeDetails();
                    fileDetail.FilePath = file;
                    int startIndex = file.LastIndexOf('\\') + 1;
                    fileName = file.Substring(startIndex, file.Length - startIndex);
                    fileDetail.FileName = fileName;

                    foreach (string fileType in fileTypes)
                    {
                        if (fileDetail.FilePath.Contains(fileType))
                        {
                            if (fileType.EndsWith("s"))
                                typeDetail.Type = fileType.Substring(0, fileType.Length - 1);
                            else
                                typeDetail.Type = fileType;

                            break;
                        }
                    }

                    if (typeDetail.Type == null)
                        typeDetail.Type = "Program";

                    fileDetail.TypeInfo = typeDetail;

                    result.Add(fileDetail);
                }
            }
            return result;
        }
    }
}

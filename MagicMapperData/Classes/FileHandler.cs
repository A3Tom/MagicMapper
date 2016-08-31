namespace MagicMapperData.Classes
{
    using Interfaces;
    using Models;
    using System;
    using System.Collections.Generic;


    class FileHandler : IFileHandler
    {
        private readonly IFileLocator fileLocator;
        private readonly IFileReader fileReader;
        private readonly IFileParser fileParser;
        private readonly IFileSaver fileSaver;

        public FileHandler(IFileLocator fileLocator, IFileReader fileReader, IFileParser fileParser, IFileSaver fileSaver)
        {
            this.fileLocator = fileLocator;
            this.fileReader = fileReader;
            this.fileParser = fileParser;
            this.fileSaver = fileSaver;
        }

        public void ScopeAllFiles()
        {
            int modelCount = 0, programCount = 0;
            List<FileDetail> fileList = fileLocator.LocateAllFiles(@".\Tests\");

            foreach(FileDetail file in fileList)
            {
                Console.WriteLine("File found : " + file.FileName);
                if (file.FileType == "Model")
                    modelCount++;
                else
                    programCount++;
            }

            Console.WriteLine(string.Format("\nTotal Classes found: {0}\nFound {1} Classes\nFound {2} Models\n", fileList.Count, programCount, modelCount));
        }
    }
}

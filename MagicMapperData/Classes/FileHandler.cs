namespace MagicMapperData.Classes
{
    using Interfaces;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;


    class FileHandler : IFileHandler
    {
        private readonly IFileLocator fileLocator;
        private readonly IFileReader fileReader;
        private readonly IFileWriter fileWriter;
        private readonly IProcessHandler processHandler;

        public FileHandler(IFileLocator fileLocator, IFileReader fileReader, IFileWriter fileWriter, IProcessHandler processHandler)
        {
            this.fileLocator = fileLocator;
            this.fileReader = fileReader;
            this.fileWriter = fileWriter;
            this.processHandler = processHandler;
        }

        public void GenerateAnalysisFile(string filePath)
        {
            string[] fileTypes = { "Models", "Types", "Views", "Properties", "Theme", "obj", "Printing" };
            List<FileDetail> fileList = fileLocator.LocateAllFiles(filePath, fileTypes);

            Console.WriteLine(string.Format("{0}Scoping files located in {2}{0}Total .cs files found: {1}{0}Below is a breakdown of each file type.{0}",
                                Environment.NewLine,
                                fileList.Count,
                                filePath));

            ReturnBreakdown_ToConsole(fileList, fileTypes);


            fileList = fileReader.ReadProgramFiles(fileList, fileTypes);

            fileList = processHandler.Return_CompleteModelDetailInfo_ToList(fileList);

            fileWriter.WriteFiles_ToJSON(fileList);
        }

        private void ReturnBreakdown_ToConsole(List<FileDetail> fileList, string[] fileTypes)
        {
            Dictionary<string, int> fileTypeBreakdown = new Dictionary<string, int>();
            var groups = fileList.GroupBy(i => i.TypeInfo.Type);

            foreach (var group in groups)
            {
                fileTypeBreakdown.Add(group.Key, group.Count());
                Console.WriteLine("{1} {0}s", group.Key, group.Count());
            }
            Console.WriteLine();
        }
    }
}

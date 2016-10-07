namespace MagicMapperData.Classes
{
    using Interfaces;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class FileReader : IFileReader
    {
        private readonly ILog logger;
        private readonly IFileWriter fileSaver;
        private readonly IPabloEscobar pablo;
        private readonly IValidationRules validateRule;
        private readonly IStringCleanser stringCleanser;

        public FileReader(ILog logger, IFileWriter fileSaver, IValidationRules validateRule, IStringCleanser stringCleanser, IPabloEscobar pablo)
        {
            this.logger = logger;
            this.fileSaver = fileSaver;
            this.validateRule = validateRule;
            this.stringCleanser = stringCleanser;
            this.pablo = pablo;
        }

        public List<FileDetail> ReadProgramFiles(List<FileDetail> fileList, string[] fileTypes)
        {
            List<FileDetail> result = new List<FileDetail>();
            string line;
            List<string> lines;

            fileList = fileList.OrderBy(x => x.TypeInfo.Type).ToList();

            foreach (FileDetail file in fileList)
            {
                lines = new List<string>();
                StreamReader reader = new StreamReader(file.FilePath);
                switch (file.TypeInfo.Type)
                {
                    case "Model":
                        while ((line = reader.ReadLine()) != null)
                        {
                            file.Namespace = "Models";
                            if (line.Replace(" ", "") != "")
                                lines.Add(line);
                        }

                        file.TypeInfo.DataModelInfo = pablo.Return_FileDataModelInfo_ToModel(lines.ToArray());
                        break;
                    case "Program":
                        while ((line = reader.ReadLine()) != null)
                        {
                            //Declare Namespace
                            if (validateRule.Validate_ObtainNamespaceHook_ToBool(line))
                            {
                                file.Namespace = stringCleanser.Return_NamespaceName_ToString(line);
                            }
                            if (line.Replace(" ", "") != "")
                                lines.Add(line);
                        }
                        file.TypeInfo.ClassInfo = pablo.Return_FileClassInfo_ToList(lines.ToArray());
                        break;
                }
                reader.Close();
                reader.Dispose();
                result.Add(file);
            }

            return result;
        }


    }
}


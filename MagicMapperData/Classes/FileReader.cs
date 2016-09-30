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
        private readonly IFileSaver fileSaver;
        private readonly IPabloEscobar pablo;
        private readonly IValidationRules validateRule;
        private readonly IStringCleanser stringCleanser;

        public FileReader(ILog logger, IFileSaver fileSaver, IValidationRules validateRule, IStringCleanser stringCleanser, IPabloEscobar pablo)
        {
            this.logger = logger;
            this.fileSaver = fileSaver;
            this.validateRule = validateRule;
            this.stringCleanser = stringCleanser;
            this.pablo = pablo;
        }

        public void ReadProgramFiles(List<FileDetail> fileList, string[] fileTypes)
        {
            string line;
            List<string> lines = new List<string>();

            fileList = fileList.OrderBy(x => x.TypeInfo.Type).ToList();

            foreach (FileDetail file in fileList)
            {
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

                        file.TypeInfo.DataModelInfo = pablo.Return_FileDataModelInfo_ToList(lines.ToArray());
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

                            file.TypeInfo.ClassInfo = pablo.Return_FileClassInfo_ToList(lines.ToArray());
                        }
                        break;
                }
                reader.Close();
                reader.Dispose();
                fileSaver.WriteFiles_ToJSON(file);
            }
        }


    }
}


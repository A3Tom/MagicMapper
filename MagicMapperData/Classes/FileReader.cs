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

<<<<<<< HEAD
<<<<<<< HEAD
        public List<FileDetail> ReadProgramFiles_ToList(List<FileDetail> fileList, string[] fileTypes)
        {
            List<FileDetail> result = new List<FileDetail>();

            ClassDetails newClass = new ClassDetails();
            List<ClassDetails> newClasses = new List<ClassDetails>();
            ClassModel newClassModel = new ClassModel();
            List<ClassModel> newClassModelsUsed = new List<ClassModel>();
            List<string[]> columnsUsed = new List<string[]>();
            List<string> modelsUsed = new List<string>();
            bool isModelRegion = false;
=======
        public List<FileDetail> ReadProgramFiles(List<FileDetail> fileList, string[] fileTypes)
        {
            List<FileDetail> result = new List<FileDetail>();
>>>>>>> overhaul
=======
        public List<FileDetail> ReadProgramFiles(List<FileDetail> fileList, string[] fileTypes)
        {
            List<FileDetail> result = new List<FileDetail>();
>>>>>>> OverhaulConflictMerge
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
<<<<<<< HEAD
<<<<<<< HEAD

                            if(line.Contains(" _parent;"))
                            {
                                newClass.ParentClass = stringCleanser.Return_ParentClass_ToString(line);
                            }

                            if (line.Contains(" class "))
                            {


                                newClass.Model = newClassModelsUsed;

                                if (newClass.Model.Count > 0)
                                    newClasses.Add(newClass);

                                newClass = new ClassDetails();
                                newClass.Name = stringCleanser.Return_ClassName_ToString(line);

                                newClassModelsUsed = new List<ClassModel>();
                                columnsUsed = new List<string[]>();
                            }

                            //Column aggregator
                            if (line.Contains("Columns.Add"))
                            {
                                formattedColumn = stringCleanser.Return_AddedColumn_ToArray(line);
                                if (!columnsUsed.Contains(formattedColumn))
                                    columnsUsed.Add(formattedColumn);
                            }

                            //Model aggregator
                            if (line.Contains("= new Models."))
                            {
                                formattedLine = stringCleanser.Return_ModelName_ToString(line);
                                if (!modelsUsed.Contains(formattedLine))
                                    modelsUsed.Add(formattedLine);
                            }
                        }
                        file.TypeInfo.ClassInfo = newClasses;
                    }
                    reader.Close();
                    reader.Dispose();
                    result.Add(file);
                    fileSaver.WriteFiles_ToTextFile(file);
                    fileSaver.WriteFiles_ToJSON(file);
=======
                            if (line.Replace(" ", "") != "")
                                lines.Add(line);
                        }
                        file.TypeInfo.ClassInfo = pablo.Return_FileClassInfo_ToList(lines.ToArray());
                        break;
>>>>>>> overhaul
=======
                            if (line.Replace(" ", "") != "")
                                lines.Add(line);
                        }
                        file.TypeInfo.ClassInfo = pablo.Return_FileClassInfo_ToList(lines.ToArray());
                        break;
>>>>>>> OverhaulConflictMerge
                }
                reader.Close();
                reader.Dispose();
                result.Add(file);
            }
<<<<<<< HEAD

            return result;
        }

<<<<<<< HEAD
        

        private bool Switch_WriteToModels_ToBool(bool modelRegion, string line)
        {
            bool result = false;

            if (modelRegion)
            {
                if (line.Length > 2)
                {
                    if (!line.Contains("///"))
                    {
                        if (!line.Contains("#"))
                        {
                            result = true;
                        }
                    }
                }
            }

            return result;
        }

        private List<ClassModel> Transcribe_ColumnData_ToClassModelsList(List<ClassModel> existingClassModels, List<string[]> columnsUsed)
        {
            List<string> uniqueModelsFromColumns = new List<string>();
            List<ClassModel> result = existingClassModels;
            ClassModel newClassModel = new ClassModel();

            foreach (string[] column in columnsUsed)
            {
                if (!uniqueModelsFromColumns.Contains(column[0]))
                    uniqueModelsFromColumns.Add(column[0]);
            }


            foreach (ClassModel ecm in existingClassModels)
            {

            }
=======
>>>>>>> overhaul

            return result;
        }
=======
>>>>>>> OverhaulConflictMerge

    }
}


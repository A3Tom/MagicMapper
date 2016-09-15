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
        private readonly IStringCleanser stringCleanser;

        public FileReader(ILog logger, IFileSaver fileSaver, IStringCleanser stringCleanser)
        {
            this.logger = logger;
            this.fileSaver = fileSaver;
            this.stringCleanser = stringCleanser;
        }

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
            string line;
            string formattedLine;
            string[] formattedColumn;

            foreach (FileDetail file in fileList)
            {
                if (file.TypeInfo.Type == "Program")
                {
                    newClasses = new List<ClassDetails>();

                    StreamReader reader = new StreamReader(file.FilePath);
                    {
                        while ((line = reader.ReadLine()) != null)
                        {
                            if(line.Contains("namespace "))
                            {
                                file.Namespace = stringCleanser.Return_NamespaceName_ToString(line);
                            }

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
                }
            }

            return result;
        }

        

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

            return result;
        }

    }
}


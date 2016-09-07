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

        public void ReadProgramFiles(List<FileDetail> fileList, string[] fileTypes)
        {
            ClassDetails newClass = new ClassDetails();
            RegionDetails newRegion = new RegionDetails();
            List<ClassDetails> newClasses = new List<ClassDetails>();
            List<string> modelsUsed = new List<string>();
            List<string[]> columnsUsed = new List<string[]>();
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

                            if (line.Contains(" class "))
                            {
                                newClass.ColumnsUsed = columnsUsed;
                                newClass.ModelsUsed = modelsUsed;

                                if (Switch_WriteToNewClass_ToBool(newClass.ModelsUsed.Count, newClass.ColumnsUsed.Count))
                                    newClasses.Add(newClass);

                                newClass = new ClassDetails();
                                newClass.Name = stringCleanser.Return_ClassName_ToString(line);
                                newClass.ProgramName = file.FileName.Replace(".cs", "");

                                modelsUsed = new List<string>();
                                columnsUsed = new List<string[]>();
                            }

                            if (line.Contains("#region"))
                                isModelRegion = (line.Contains("Models") ? true : false);

                            //Column aggregator
                            if (line.Contains("Columns.Add"))
                            {
                                formattedColumn = stringCleanser.Return_AddedColumn_ToArray(line);
                                if (!columnsUsed.Contains(formattedColumn))
                                    columnsUsed.Add(formattedColumn);
                            }

                            //Model aggregator
                            if (Switch_WriteToModels_ToBool(isModelRegion, line))
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
                    fileSaver.WriteFiles_ToTextFile(file);
                }
            }
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

        private bool Switch_WriteToNewClass_ToBool(int modelCount, int columnCount)
        {
            bool result = false;

            if (modelCount == 0 && columnCount > 0)
                result = true;

            if (modelCount > 0 && columnCount == 0)
                result = true;

            if (modelCount > 0 && columnCount > 0)
                result = true;

            return result;
        }


    }
}


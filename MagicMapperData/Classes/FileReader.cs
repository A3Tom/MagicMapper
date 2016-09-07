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
        private readonly IStringCleanser stringCleanser;

        public FileReader(ILog logger, IStringCleanser stringCleanser)
        {
            this.logger = logger;
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
                    WriteFiles_ToTextFile(file);
                }
            }
        }

        public void WriteFiles_ToTextFile(FileDetail file)
        {
            List<string> totalModelsUsed = new List<string>();
            List<string[]> totalColumnsUsed = new List<string[]>();

            string outputDirectory = @"./Tests/Output/" + file.Namespace + "/";
            string outputName = file.FileName.Replace(".cs", "") + ".txt";

            if (!Directory.Exists(outputDirectory))
                Directory.CreateDirectory(outputDirectory);

            StreamWriter writer = new StreamWriter(outputDirectory + outputName);
            {
                try
                {
                    foreach (ClassDetails classDetail in file.TypeInfo.ClassInfo)
                    {
                        writer.WriteLine(string.Format("{2}Class: {0} within Program {1}{2}",
                                                        classDetail.Name,
                                                        classDetail.ProgramName,
                                                        Environment.NewLine));

                        if (classDetail.ModelsUsed.Count > 0)
                        {
                            writer.WriteLine("Models used:");
                            foreach (string model in classDetail.ModelsUsed)
                            {
                                writer.WriteLine(model);
                                if(!totalModelsUsed.Contains(model))
                                    totalModelsUsed.Add(model);
                            }
                        }

                        if (classDetail.ColumnsUsed.Count > 0)
                        {
                            writer.WriteLine("\n\nColumns used:");
                            foreach (string[] column in classDetail.ColumnsUsed)
                            {
                                writer.WriteLine(string.Format("{0}.{1}",
                                                    column[0],
                                                    column[1]));
                                if (!totalColumnsUsed.Contains(column))
                                    totalColumnsUsed.Add(column);
                            }
                        }
                    }

                    totalModelsUsed = totalModelsUsed.OrderBy(o => o).ToList();
                    totalColumnsUsed = totalColumnsUsed.OrderBy(o => o[1]).OrderBy(e => e[0]).ToList();
                    totalColumnsUsed = totalColumnsUsed.Distinct().ToList();

                    writer.WriteLine(string.Format("{0} ** Summary ** {0}", Environment.NewLine));
                    writer.WriteLine(string.Format("{0} * Unique Models Used * {0}", Environment.NewLine));
                    foreach(string model in totalModelsUsed)
                        writer.WriteLine(model);

                    writer.WriteLine(string.Format("{0}{0} * Unique Columns Used * {0}", Environment.NewLine));
                    foreach (string[] column in totalColumnsUsed)
                    {
                        writer.WriteLine(string.Format("{0}.{1}",
                                                        column[0],
                                                        column[1]));
                    }

                    writer.Close();
                    writer.Dispose();
                }
                catch (Exception ex)
                {
                    logger.Error(ex.Message);
                    logger.Error(ex.StackTrace);
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


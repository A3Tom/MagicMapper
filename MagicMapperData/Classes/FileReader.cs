namespace MagicMapperData.Classes
{
    using Interfaces;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.IO;

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
            List<RegionDetails> newRegions = new List<RegionDetails>();
            List<string> modelsUsed = new List<string>();
            List<string[]> columnsUsed = new List<string[]>();
            bool isModelRegion = false;
            string line;
            string formattedLine;
            string[] formattedColumn;


            foreach (FileDetail file in fileList)
            {
                //StreamReader reader = new StreamReader(@"F:\dev\Git\MagicMapper\Build\Tests\bc\MandCo.BranchAccounting.Reports\BranchStatementsHTMBc213.cs");
                StreamReader reader = new StreamReader(file.FilePath);
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        #region Class Check
                        if (line.Contains(" class "))
                        {
                            if(newClass != null)
                            {
                                newClass.RegionInfo = newRegions;
                                newClasses.Add(newClass);
                            }
                            newClass = new ClassDetails();
                            newClass.Name = stringCleanser.Return_ClassName_ToString(line);
                            newClass.ProgramName = file.FileName.Substring(0, file.FileName.Length - 3);
                            newRegions.Clear();
                        }
                        #endregion

                        #region Region Check

                        if (line.Contains("#region"))
                        {
                            newRegion = new RegionDetails();
                            newRegions.Clear();
                            modelsUsed.Clear();
                            columnsUsed.Clear();
                            newRegion.RegionName = stringCleanser.Return_RegionName_ToString(line);
                            isModelRegion = (line.Contains("Models") ? true : false);
                        }

                        if (line.Contains("Columns.Add"))
                        {
                            formattedColumn = stringCleanser.Return_AddedColumn_ToArray(line);
                            if (!columnsUsed.Contains(formattedColumn))
                                columnsUsed.Add(formattedColumn);
                        }

                        if (isModelRegion && line.Length > 2 && !line.Contains("///") && !line.Contains("#"))
                        {
                            formattedLine = stringCleanser.Return_ModelName_ToString(line);
                            if (!modelsUsed.Contains(formattedLine))
                                modelsUsed.Add(formattedLine);
                        }

                        if (line.Contains("#endregion"))
                        {
                            newRegion.ModelsUsed = modelsUsed;
                            newRegion.ColumnsUsed = columnsUsed;
                            if(modelsUsed.Count > 0 || columnsUsed.Count > 0)
                                newRegions.Add(newRegion);
                        }
                        #endregion
                    }
                    file.TypeInfo.ClassInfo = newClasses;
                }
                WriteFiles_ToTextFile(file);
            }
        }

        public void WriteFiles_ToTextFile(FileDetail file)
        {

            StreamWriter writer = new StreamWriter(@"./Tests/Output/" + file.FileName.Replace(".cs", "") + ".txt");
            {
                try
                {
                    foreach (ClassDetails classDetail in file.TypeInfo.ClassInfo)
                    {
                        writer.WriteLine(string.Format("{2}Class: {0} within Program {1}{2}",
                                                        classDetail.Name,
                                                        classDetail.ProgramName,
                                                        Environment.NewLine));

                        foreach (RegionDetails regionDetail in classDetail.RegionInfo)
                        {
                            writer.WriteLine("Models used:");
                            foreach (string model in regionDetail.ModelsUsed)
                            {
                                writer.WriteLine(model);
                            }

                            writer.WriteLine("\n\nColumns used:");
                            foreach (string[] column in regionDetail.ColumnsUsed)
                            {
                                writer.WriteLine(string.Format("{0}.{1}",
                                                    column[0],
                                                    column[1]));
                            }
                        }
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
    }
}


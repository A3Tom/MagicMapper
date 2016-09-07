namespace MagicMapperData.Classes
{
    using Interfaces;
    using Models;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class FileSaver : IFileSaver
    {
        private readonly ILog logger;

        public FileSaver(ILog logger)
        {
            this.logger = logger;
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
                                if (!totalModelsUsed.Contains(model))
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
                    foreach (string model in totalModelsUsed)
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

        public void WriteFiles_ToJSON(FileDetail file)
        {
            string outputDirectory = @"./Tests/Output/" + file.Namespace + "/";
            string outputName = file.FileName.Replace(".cs", "") + ".Json";

            if (!Directory.Exists(outputDirectory))
                Directory.CreateDirectory(outputDirectory);

            string json = JsonConvert.SerializeObject(file, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(outputDirectory + outputName, json);
        }
    }
}

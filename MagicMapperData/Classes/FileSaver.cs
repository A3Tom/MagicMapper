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

        public void WriteFiles_ToJSON(FileDetail file)
        {
            string outputDirectory = @"./Tests/Output/" + file.Namespace + "/";
            string outputName = file.FileName.Replace(".cs", "") + ".Json";

            if (!Directory.Exists(outputDirectory))
                Directory.CreateDirectory(outputDirectory);

            var _jsonSerializerSettings = new JsonSerializerSettings()
                {
                    NullValueHandling = NullValueHandling.Ignore
                };

            string json = JsonConvert.SerializeObject(file, Newtonsoft.Json.Formatting.Indented, _jsonSerializerSettings);
            System.IO.File.WriteAllText(outputDirectory + outputName, json);
        }
    }
}

namespace MagicMapperData.Classes
{
    using Interfaces;
    using Models;
    using System.Collections.Generic;

    public class ProcessHandler : IProcessHandler
    {
        public List<FileDetail> Return_CompleteModelDetailInfo_ToList(List<FileDetail> fileDetails)
        {
            Dictionary<string, string> modelDictionary = new Dictionary<string, string>();

            foreach (FileDetail file in fileDetails)
            {
                if (file.TypeInfo.Type == "Model")
                {
                    modelDictionary.Add(file.TypeInfo.DataModelInfo.ModelName, file.TypeInfo.DataModelInfo.LiteralDatabaseName);
                }
                else if (file.TypeInfo.Type == "Program")
                {
                    foreach (ClassDetails classDetail in file.TypeInfo.ClassInfo)
                    {
                        foreach (ModelDetails model in classDetail.Models)
                        {
                            string result;
                            if (modelDictionary.TryGetValue(model.ModelName, out result))
                            {
                                model.LiteralName = result;
                            }
                        }
                    }
                }
            }

            return fileDetails;
        }
    }
}

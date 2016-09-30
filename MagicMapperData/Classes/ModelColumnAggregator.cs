namespace MagicMapperData.Classes
{
    using System.Collections.Generic;
    using Interfaces;
    using Models;
    using System;

    public class ModelColumnAggregator : IModelColumnAggregator
    {
        private readonly ILog Logger;

        public ModelColumnAggregator(ILog Logger)
        {
            this.Logger = Logger;
        }


        public List<ModelDetails> Return_PopulatedModelDetails_ToList(List<ModelDetails> modelsUsed, List<string[]> columnsUsed)
        {
            try
            {
                if (Return_VariableModelRequired_ToBool(columnsUsed))
                {
                    ModelDetails variableModel = new ModelDetails()
                        {
                            ModelName = "Variables"
                        };
                    modelsUsed.Add(variableModel);
                }

                foreach (ModelDetails model in modelsUsed)
                {
                    List<string> columnNames = new List<string>();

                    foreach (string[] column in columnsUsed)
                    {
                        if (column[0].Contains(model.ModelName))
                        {
                            columnNames.Add(column[1]);
                        }
                    }

                    model.ColumnsUsed = columnNames;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                Logger.Error(ex.StackTrace);
            }
            return modelsUsed;
        }

        private bool Return_VariableModelRequired_ToBool(List<string[]> columnsUsed)
        {
            bool result = false;

            foreach (string[] columns in columnsUsed)
            {
                if (columns[0].Contains("Variables"))
                    return true;
            }

            return result;
        }
    }
}

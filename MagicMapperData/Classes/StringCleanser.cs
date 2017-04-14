namespace MagicMapperData.Classes
{
    using Interfaces;
    using System.Collections.Generic;

    public class StringCleanser : IStringCleanser
    {
        public string Return_ClassName_ToString(string line)
        {
            string[] modifiersToReplace = { "class", "public", "internal", "static" };
            int endOfLine = line.Length;
            if (line.Contains(":"))
                endOfLine = line.IndexOf(":");

            line = line.Substring(0, endOfLine);

            foreach (string mod in modifiersToReplace)
                line = line.Replace(mod, "");

            line = line.TrimStart(' ');
            line = line.TrimEnd(' ');

            return line;
        }

        public string Return_NamespaceName_ToString(string line)
        {
            line = line.Replace("namespace ", "");

            return line;
        }

        public string Return_ModelName_ToString(string line)
        {
            try
            {
                line = line.Substring(0, line.IndexOf("=") - 1);
                line = line.TrimStart(' ');
                line = line.Substring(line.IndexOf(".") + 1);
                line = line.Substring(0, line.LastIndexOf(" "));
            }
            catch
            {
                line = "Model name incompatable";
            }
            return line;
        }

        public string Return_ProgramName_ToString(string line)
        {

            return line;
        }

        public string Return_ParentClass_ToString(string line)
        {
            line = line.Replace(" _parent;", "");
            line = line.TrimStart(' ');
            return line;
        }

        public string[] Return_AddedColumn_ToArray(string line)
        {
            string[] result = new string[2];
            try
            {
                line = line.Substring(line.IndexOf("(") + 1, line.IndexOf(")") - (line.IndexOf("(") + 1));
                if (line.Contains("."))
                {
                    result[0] = line.Substring(0, line.IndexOf("."));
                    result[1] = line.Substring(line.IndexOf(".") + 1, line.Length - (line.IndexOf(".") + 1));
                }
                else
                {
                    result[0] = "Variables";
                    result[1] = line;
                }
            }
            catch
            {
                result[0] = "null";
                result[1] = "null";
            }

            return result;
        }

        public string Return_RegionName_ToString(string line)
        {
            string result = line;

            line = line.Replace("#region", "");
            line = line.TrimStart(' ');

            return line;
        }

        public string Return_ExternalCallName_ToString(string line)
        {
            string result = line;

            result = line.Substring(line.IndexOf('<') + 1, (line.IndexOf('>') - (line.IndexOf('<') + 1)));

            return result;
        }

        public string[] Return_ExternalCallParams_ToArray(string line)
        {
            string rawParams = line;
            string criteria = ").Run(";
            int runStart = line.IndexOf(criteria);

            rawParams = line.Substring((runStart + criteria.Length), (line.IndexOf(");")) - (runStart + criteria.Length));

            var result = rawParams.Split(',');

            if (rawParams.Contains(","))
                result = rawParams.Split(',');
            else
                result = null;

            return result;
        }

        public string Return_AddAdditionalParam_ToString(string line)
        {
            string result;

            result = line.Trim();

            return result;
        }

        public string[] Return_DataModelDetails_ToArray(string line)
        {
            string[] result = new string[3];
            string[] modifiersToReplace = { " ", "\"", "(", ")" };

            line = line.Substring(line.IndexOf('\"') + 1, (line.LastIndexOf(')') - line.IndexOf('\"')));

            foreach (string mod in modifiersToReplace)
                line = line.Replace(mod, "");

            result = line.Split(',');

            if (result[0].Contains("."))
                result[0] = Return_CleansedTableColumnConcat_ToString(result[0]);

            if (result[2] != null)
                result[2] = Return_CleansedTableColumnConcat_ToString(result[2]);

            return result;
        }

        private string Return_CleansedTableColumnConcat_ToString(string line)
        {
            string result;
            int startIndex = line.IndexOf('.') + 1;

            result = line.Substring(startIndex, line.Length - startIndex);

            return result;
        }

        public string Return_SQLModelUsed_ToString(string line)
        {
            string result = "";

            int startCutIndex = line.IndexOf('(') + 1;
            int endCutIndex = line.LastIndexOf(',');

            if (endCutIndex > 0)
                result = line.Substring(startCutIndex, (endCutIndex - startCutIndex));

            return result;
        }
    }
}

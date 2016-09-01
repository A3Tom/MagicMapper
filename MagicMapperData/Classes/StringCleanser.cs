namespace MagicMapperData.Classes
{
    using Interfaces;

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

            return line;
        }

        public string Return_ModelName_ToString(string line)
        {
            line = line.Substring(0, line.IndexOf("=") - 1);
            line = line.TrimStart(' ');
            line = line.Substring(line.IndexOf(".") + 1);
            line = line.Substring(0, line.LastIndexOf(" "));

            return line;
        }

        public string Return_ProgramName_ToString(string line)
        {

            return line;
        }

        public string[] Return_AddedColumn_ToArray(string line)
        {
            string[] result = new string[2];

            line = line.Substring(line.IndexOf("(") + 1, line.IndexOf(")") - (line.IndexOf("(") + 1));
            if (line.Contains("."))
            {
                result[0] = line.Substring(0, line.IndexOf("."));
                result[1] = line.Substring(line.IndexOf(".") + 1, line.Length - (line.IndexOf(".") + 1));
            }
            else
            {
                result[0] = "Variable";
                result[1] = line;
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
    }
}

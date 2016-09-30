namespace MagicMapperData.Classes
{
    using Interfaces;
    using Models;

    public class ValidationRules : IValidationRules
    {
        public bool Validate_ObtainNamespaceHook_ToBool(string line)
        {
            bool result = false;

            if (line.Contains("namespace "))
                result = true;

            return result;
        }
        public bool Validate_NewClassHook_ToBool(string line)
        {
            bool result = false;

            if (line.Contains(" class "))
                result = true;

            return result;
        }
        public bool Validate_ParentClassHook_ToBool(string line)
        {
            bool result = false;

            if (line.Contains(" _parent;"))
                result = true;

            return result;
        }
        public bool Validate_NewColumnHook_ToBool(string line)
        {
            bool result = false;

            if (line.Contains("Columns.Add"))
                result = true;

            return result;
        }
        public bool Validate_NewModelHook_ToBool(string line)
        {
            bool result = false;

            if (line.Contains(" new Models."))
                result = true;

            return result;
        }
        public bool Validate_AddNewClass_ToBool(ClassDetails newClass)
        {
            bool result = false;

            if (newClass.Name != null)
                result = true;

            return result;
        }


    }
}

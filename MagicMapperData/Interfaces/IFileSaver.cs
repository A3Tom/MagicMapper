namespace MagicMapperData.Interfaces
{
    using Models;

    public interface IFileSaver
    {
        public void WriteFiles_ToTextFile(FileDetail file);
        public void WriteFiles_ToJSON(FileDetail file);
    }
}

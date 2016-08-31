namespace MagicMapperData
{
    using Interfaces;
    using System;
    using System.Threading;

    class MagicMapper
    {
        static void Main(string[] args)
        {
            CompositionRoot.Wire(new ApplicationModule());

            var MagicMapper = CompositionRoot.Resolve<IApp>();
            Console.WriteLine("Magic Mapping in progress ... ");
            try
            {
                MagicMapper.Run();
                Console.WriteLine("Magic successfully mapped.");
            }
            catch
            {
                Console.WriteLine("Error in processing.");
            }
            finally
            {
                Console.WriteLine("Magic Mapper Closing.");
                Thread.Sleep(92500);
            }

        }
    }
}

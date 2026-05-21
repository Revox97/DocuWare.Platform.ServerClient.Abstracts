using System.Reflection;
using DocuWare.Platform.ServerClient.Abstracts.Generation.Services.Generation;

// TODO HANDLE DocuWare.Platform.ServerClient.Extensions
// TODO HANDLE GENERIC CALLS Call<T>...

namespace DocuWare.Platform.ServerClient.Abstracts.Generation
{
    internal class Program
    {
        static void Main()
        {
            DeleteExistingFiles();
            GenerateTopLevelTypes();
            GenerateInstanceTypes();

            Console.WriteLine("Finished generation.");
        }

        private static void DeleteExistingFiles()
        {
            Console.WriteLine("Deleting existing files.");
            Directory.EnumerateDirectories(Paths.GenerationFolder).ToList().ForEach(x => Directory.Delete(x, true));
        }

        private static void GenerateTopLevelTypes()
        {
            Console.WriteLine("Starting generation of DocuWare.Platform.ServerClient.Abstracts");
            Console.WriteLine("Generating static types interface.");
            new ServiceConnectionGenerationService().Generate(typeof(ServerClient.ServiceConnection));
        }

        private static void GenerateInstanceTypes()
        {
            Console.WriteLine("Generating instance types.");
            Assembly assembly = Assembly.GetAssembly(typeof(ServerClient.ServiceConnection))
                ?? throw new Exception("Assembly could not be loaded.");

            GenerateEnums(assembly);
            GenerateInstances(assembly);

            // TODO Generate extensions
        }

        private static void GenerateEnums(Assembly assembly)
        {
            EnumGenerationService enumGenerationService = new();
            Type[] enumTypes = [.. assembly.GetExportedTypes().Where(t => t.IsEnum)];

            for (int i = 0; i < enumTypes.Length; i++)
                enumGenerationService.Generate(enumTypes[i]);
        }

        private static void GenerateInstances(Assembly assembly)
        {
            InstanceGenerationService instanceGenerationService = new();
            Type[] types = [.. assembly.GetExportedTypes().Where(t => t.IsClass)];

            for (int i = 0; i < types.Length; i++)
                instanceGenerationService.Generate(types[i]);
        }
    }
}

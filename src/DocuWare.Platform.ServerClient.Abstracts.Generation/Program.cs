using System.Reflection;
using DocuWare.Platform.ServerClient.Abstracts.Generation.Services.Generation;

// TODO HANDLE DocuWare.Platform.ServerClient.Extensions

namespace DocuWare.Platform.ServerClient.Abstracts.Generation
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Deleting existing files.");
            Directory.EnumerateFiles(Paths.GenerationFolder).ToList().ForEach(File.Delete);

            Console.WriteLine("Starting generation of DocuWare.Platform.ServerClient.Abstracts");
            Console.WriteLine("Generating static types interface.");
            new ServiceConnectionGenerationService().Generate(typeof(ServiceConnection));

            Console.WriteLine("Generating instance types.");
            Assembly assembly = Assembly.GetAssembly(typeof(ServiceConnection))
                ?? throw new Exception("Assembly could not be loaded.");

            EnumGenerationService enumGenerationService = new();
            Type[] enumTypes = [.. assembly.GetExportedTypes().Where(t => t.IsEnum)];

            for (int i = 0; i < enumTypes.Length; i++)
                enumGenerationService.Generate(enumTypes[i]);

            InstanceGenerationService instanceGenerationService = new();
            Type[] types = [.. assembly.GetExportedTypes().Where(t => t.IsClass && (t.GetConstructors().Length > 0 || t.Name.Contains("ServiceConnection")))]; // Avoid any static types

            for (int i = 0; i < types.Length; i++)
                instanceGenerationService.Generate(types[i]);

            // TODO Generate extensions

            Console.WriteLine("Finished generation.");
        }
    }
}

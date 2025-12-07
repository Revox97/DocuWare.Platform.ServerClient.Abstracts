using System.Reflection;
using DocuWare.Platform.ServerClient.Abstracts.Generation.Services.Generation;

namespace DocuWare.Platform.ServerClient.Abstracts.Generation
{
    internal class Program
    {
        // TODO add handling of async methods
        // TODO add handling of Task<DeserializedHttpResponse<T>> methods
        // TODO add handling of enums
        static void Main()
        {
            Console.WriteLine("Starting generation of DocuWare.Platform.ServerClient.Abstracts");
            Console.WriteLine("Generating static types interface.");
            new ServiceConnectionGenerationService().Generate(typeof(ServiceConnection));

            Console.WriteLine("Generating instance types.");
            Assembly assembly = Assembly.GetAssembly(typeof(ServiceConnection))
                ?? throw new Exception("Assembly could not be loaded.");

            InstanceGenerationService instanceGenerationService = new();
            Type[] types = [.. assembly.GetExportedTypes().Where(t => t.IsClass)];

            for (int i = 0; i < types.Length; i++)
                instanceGenerationService.Generate(types[i]);

            Console.WriteLine("Generating enumerations.");
            // TODO generate enums
        }
    }
}

using System.Reflection;
using DocuWare.Platform.ServerClient.Abstracts.Generation.Services.Generation;

namespace DocuWare.Platform.ServerClient.Abstracts.Generation
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Starting generation of DocuWare.Platform.ServerClient.Abstracts");
            Console.WriteLine("Generating static types interface.");
            new ServiceConnectionGenerationService().Generate(typeof(ServiceConnection));

            Console.WriteLine("Generating instance types.");
            InstanceGenerationService instanceGenerationService = new();
            Assembly? assembly = Assembly.GetAssembly(typeof(ServiceConnection));
            Type[] types = [.. assembly.GetExportedTypes().Where(t => t.IsClass)];

            for (int i = 0; i < types.Length; i++)
                instanceGenerationService.Generate(types[i]);
        }
    }
}

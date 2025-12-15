using System.Reflection;
using System.Text;
using DocuWare.Platform.ServerClient.Abstracts.Generation.Contracts;
using DocuWare.Platform.ServerClient.Abstracts.Generation.Extensions;

namespace DocuWare.Platform.ServerClient.Abstracts.Generation.Services.Generation
{
    internal class ServiceConnectionGenerationService : IGenerationService
    {
        public void Generate(Type type)
        {
            GenerateInterface(type);
            GenerateImplementation(type);
        }

        private static void GenerateInterface(Type type)
        {
            Console.WriteLine("Generating IDocuWare");
            MethodInfo[] methods = type.GetMethods(BindingFlags.Static | BindingFlags.Public);
            string template = File.ReadAllText("Templates/InterfaceTemplate.tmp");
            template = template.Replace("{0}", "IDocuWare").Replace("{1}", string.Empty);
            string methodList = string.Empty;

            for (int i = 0; i < methods.Length; i++)
            {
                MethodInfo method = methods[i];

                string returnTypeName = method.ReturnType.GetParsedName();
                string parameters = method.GetParsedParameterDefinitions();
                string result = $"{returnTypeName} {method.Name}({parameters});";

                methodList += $"{StringConstants.LineEndingWithTwoTabs}{result}"; 
            }

            template = template.Replace("{2}", methodList);
            using FileStream fStream = File.Create(Path.Combine(Paths.GenerationFolder, "IDocuWare.g.cs"));
            fStream.Write(Encoding.UTF8.GetBytes(template ?? string.Empty));
        }

        private static void GenerateImplementation(Type type)
        {
            Console.WriteLine("Generating RealDocuWare.cs");
            MethodInfo[] methods = type.GetMethods(BindingFlags.Static | BindingFlags.Public);
            string template = File.ReadAllText("Templates/RealDocuWareTemplate.tmp");
            string methodList = string.Empty;

            for (int i = 0; i < methods.Length; i++)
            {
                MethodInfo method = methods[i];

                string returnTypeName = method.ReturnType.GetParsedName();
                string parameterDefinitions = method.GetParsedParameterDefinitions();
                string parameters = method.GetParsedParameters();
                string async = returnTypeName.StartsWith("Task") ? "async " : string.Empty;
                string result = $"public {async}{returnTypeName} {method.Name}({parameterDefinitions}){StringConstants.LineEndingWithTwoTabs}{{{StringConstants.LineEndingWithThreeTabs}return SDK.ServiceConnection.{method.Name}({parameters});{StringConstants.LineEndingWithTwoTabs}}}";

                methodList += $"{StringConstants.LineEnding}{StringConstants.LineEndingWithTwoTabs}{result}"; 
            }

            template = template.Replace("{0}", methodList);
            Directory.CreateDirectory("Generated");
            using FileStream fStream = File.Create(Path.Combine(Paths.GenerationFolder, "RealDocuWare.g.cs"));
            fStream.Write(Encoding.UTF8.GetBytes(template ?? string.Empty));
        }
    }
}

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
                string result = $"public {async}{returnTypeName} {method.Name}({parameterDefinitions})\n\t{{\n\t\treturn SDK.ServiceConnection.{method.Name}({parameters});\n\t}}";

                if (methodList == string.Empty)
                    methodList += result;
                else
                    methodList += $"\n\n\t{result}"; 
            }

            template = template.Replace("{0}", methodList);
            Directory.CreateDirectory("Generated");
            using FileStream fStream = File.Create("Generated/RealDocuWare.g.cs");
            fStream.Write(Encoding.UTF8.GetBytes(template ?? string.Empty));
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

                if (methodList == string.Empty)
                    methodList += result;
                else
                    methodList += $"\n    {result}"; 
            }

            template = template.Replace("{2}", methodList);
            Directory.CreateDirectory("Generated");
            using FileStream fStream = File.Create("Generated/IDocuWare.g.cs");
            fStream.Write(Encoding.UTF8.GetBytes(template ?? string.Empty));
        }
    }
}

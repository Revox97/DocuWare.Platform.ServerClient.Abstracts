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
            Console.WriteLine("Generating IDocuWare");
            MethodInfo[] methods = type.GetMethods(BindingFlags.Static | BindingFlags.Public);
            string template = File.ReadAllText("Templates/InterfaceTemplate.tmp");
            template = template.Replace("{0}", "IDocuWare").Replace("{1}", string.Empty);
            string methodList = string.Empty;

            for (int i = 0; i < methods.Length; i++)
            {
                MethodInfo method = methods[i];

                string returnTypeName = method.ReturnType.GetParsedName();
                string parameters = method.GetParsedParameters();
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

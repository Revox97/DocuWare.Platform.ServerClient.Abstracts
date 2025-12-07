using System.Reflection;
using System.Text;
using DocuWare.Platform.ServerClient.Abstracts.Generation.Contracts;
using DocuWare.Platform.ServerClient.Abstracts.Generation.Extensions;

namespace DocuWare.Platform.ServerClient.Abstracts.Generation.Services.Generation
{
    internal class InterfaceGenerationService : IGenerationService
    {
        public void Generate(Type type)
        {
            string interfaceName = $"I{type.Name}";
            Console.WriteLine($"Generating {interfaceName}");
            string template = File.ReadAllText("Templates/InterfaceTemplate.tmp");
            template = template.Replace("{0}", interfaceName).Replace("{1}", string.Empty);

            string propertyList = GenerateProperties(type);
            string methodList = GenerateMethods(type);

            string result = propertyList + (methodList != string.Empty ? "\n" : string.Empty) + methodList;

            template = template.Replace("{2}", result);
            Directory.CreateDirectory("Generated");
            using FileStream fStream = File.Create($"Generated/{interfaceName}.g.cs");
            fStream.Write(Encoding.UTF8.GetBytes(template ?? string.Empty));
        }

        private static string GenerateProperties(Type type)
        {
            PropertyInfo[] properties = type.GetProperties();
            string propertyList = string.Empty;

            for (int i = 0; i < properties.Length; i++)
            {
                PropertyInfo property = properties[i];

                string typeName = property.PropertyType.GetParsedName();
                string name = property.Name;
                bool hasGetter = property.GetGetMethod() is not null;
                bool hasSetter = property.GetSetMethod() is not null;
                string result = $"{typeName} {name} {{ {(hasGetter ? "get;" : string.Empty)}{(hasGetter && hasSetter ? " " : string.Empty)}{(hasSetter ? "set;" : string.Empty)} }}";

                if (propertyList == string.Empty)
                    propertyList += $"{result}";
                else
                    propertyList += $"\n    {result}"; 
            }

            return propertyList;
        }

        private static string GenerateMethods(Type type)
        {
            MethodInfo[] methods = [.. type.GetMethods(BindingFlags.Instance | BindingFlags.Public).Where(m => !m.IsSpecialName)];

            string methodList = string.Empty;

            for (int i = 0; i < methods.Length; i++)
            {
                MethodInfo method = methods[i];

                if (method.DeclaringType != type)
                    continue;

                string returnTypeName = method.ReturnType.GetParsedName();
                string parameters = method.GetParsedParameters();
                string result = $"{returnTypeName} {method.Name}({parameters});";

                if (methodList == string.Empty)
                    methodList += $"    {result}";
                else
                    methodList += $"\n    {result}"; 
            }

            return methodList;
        }
    }
}

using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using DocuWare.Platform.ServerClient.Abstracts.Generation.Contracts;
using DocuWare.Platform.ServerClient.Abstracts.Generation.Extensions;

namespace DocuWare.Platform.ServerClient.Abstracts.Generation.Services.Generation
{
    internal class ImplementationGenerationService : IGenerationService
    {
        public void Generate(Type type)
        {
            Console.WriteLine($"Generating {type.Name}");

            string template = File.ReadAllText("Templates/ImplementationTemplate.tmp");
            template = template.Replace("{0}", type.Name).Replace("{1}", $"I{type.Name}");

            string propertyList = GenerateProperties(type);
            string methodList = GenerateMethods(type);

            string result = propertyList + (methodList != string.Empty ? "\n" : string.Empty) + methodList;

            template = template.Replace("{2}", result);
            Directory.CreateDirectory("Generated");
            using FileStream fStream = File.Create($"Generated/{type.Name}.g.cs");
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

                string getter = $"get => Obj.{name};";
                string setter = $"set => Obj.{name} = value;";
                string result = $"{typeName} {name} {{ {(hasGetter ? getter : string.Empty)}{(hasGetter && hasSetter ? " " : string.Empty)}{(hasSetter ? setter : string.Empty)} }}";

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
                string result = $"{returnTypeName} {method.Name}({parameters}) => Obj.{method.Name};";

                if (methodList == string.Empty)
                    methodList += $"    {result}";
                else
                    methodList += $"\n    {result}"; 
            }

            return methodList;
        }
    }
}

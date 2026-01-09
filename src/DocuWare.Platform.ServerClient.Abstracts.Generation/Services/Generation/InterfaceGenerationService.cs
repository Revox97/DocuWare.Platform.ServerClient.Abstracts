using System.Reflection;
using System.Text;
using System.Xml.Serialization;
using DocuWare.Platform.ServerClient.Abstracts.Generation.Contracts;
using DocuWare.Platform.ServerClient.Abstracts.Generation.Extensions;
using DocuWare.Platform.ServerClient.Abstracts.Generation.Wrapper;

namespace DocuWare.Platform.ServerClient.Abstracts.Generation.Services.Generation
{
    internal class InterfaceGenerationService : IGenerationService
    {
        public void Generate(Type type)
        {
            if (type.Name.EndsWith("Extensions"))
                return;

            string interfaceName = $"I{type.Name}";
            Console.WriteLine($"Generating {interfaceName}.cs");
            string template = File.ReadAllText("Templates/Interface.template");
            template = template.Replace("{0}", interfaceName).Replace("{1}", string.Empty).Replace("{3}", string.Empty);

            string propertyList = GenerateProperties(type);
            string methodList = GenerateMethods(type);

            string result = propertyList + (methodList != string.Empty ? StringConstants.LineEnding : string.Empty) + methodList;

            template = template.Replace("{2}", result);
            using FileStream fStream = File.Create(Path.Combine(Paths.GenerationFolder, $"{interfaceName}.g.cs"));
            fStream.Write(Encoding.UTF8.GetBytes(template ?? string.Empty));
        }

        private static string GenerateProperties(Type type)
        {
            PropertyInfo[] properties = [.. type.GetProperties(BindingFlags.Instance | BindingFlags.Public).Where(p => p.CustomAttributes.Any(a => a.AttributeType != typeof(XmlIgnoreAttribute)))];
            string propertyList = string.Empty;

            for (int i = 0; i < properties.Length; i++)
            {
                PropertyInfo property = properties[i];

                TypeDef typeDefinition = property.PropertyType.GetTypeDefinition();
                string returnTypeName = typeDefinition.GetReturnTypeName();

                // TODO improve to a more general approach
                if (returnTypeName.Equals("IDictionary"))
                    returnTypeName = "System.Collections.IDictionary";

                string name = property.Name;
                bool hasGetter = property.GetGetMethod() is not null;
                bool hasSetter = property.GetSetMethod() is not null;
                string result = $"{returnTypeName} {name} {{ {(hasGetter ? "get;" : string.Empty)}{(hasGetter && hasSetter ? " " : string.Empty)}{(hasSetter ? "set;" : string.Empty)} }}";

                propertyList += $"{StringConstants.LineEndingWithTwoTabs}{result}"; 
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

                if (method.DeclaringType != type || method.Name.Equals("ToString"))
                    continue;

                string returnTypeName = method.ReturnType.GetTypeDefinition().GetReturnTypeName();
                string parameters = method.GetParsedParameterDefinitions();
                string result = $"{returnTypeName} {method.Name}({parameters});";

                methodList += $"{StringConstants.LineEndingWithTwoTabs}{result}"; 
            }

            return methodList;
        }
    }
}

using System.Reflection;
using DocuWare.Platform.ServerClient.Abstracts.Generation.Templates;

namespace DocuWare.Platform.ServerClient.Abstracts.Generation.Services.PropertyStrategies
{
    internal class DocuWareListPropertyGenerationStrategy(PropertyGenerationType generationType) : PropertyGenerationStrategy(generationType)
    {
        protected override string GenerateGet(PropertyInfo property, string returnTypeName, string name)
        {
            string template = TemplateService.DocuWareListPropertyGetTemplate;
            return template.Replace("{type}", returnTypeName)
                           .Replace("{name}", name)
                           .Replace("{targetType}", returnTypeName[6..^1])
                           .Replace("{interfaceType}", returnTypeName[5..^1]);
        }

        protected override string GenerateGetSet(PropertyInfo property, string returnTypeName, string name)
        {
            string template = TemplateService.DocuWareListPropertyGetSetTemplate;
            return template.Replace("{type}", returnTypeName)
                           .Replace("{name}", name)
                           .Replace("{targetType}", GenerateTypeName(property, returnTypeName))
                           .Replace("{interfaceType}", returnTypeName[5..^1]);
        }

        protected static string GenerateTypeName(PropertyInfo property, string returnTypeName)
        {
            string ns = property.PropertyType.GenericTypeArguments[0].Namespace ?? "";
            string typeNameFormatted = returnTypeName[6..^1];

            if (typeNameFormatted.Equals("KeyValuePair"))
            {
                ns = ns.Replace("DocuWare.Platform.ServerClient", "DocuWare.Platform.ServerClient.Abstracts");
                typeNameFormatted = $"{ns}.{typeNameFormatted}";
            }

            return typeNameFormatted;
        }
    }
}

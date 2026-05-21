using System.Reflection;
using DocuWare.Platform.ServerClient.Abstracts.Generation.Templates;

namespace DocuWare.Platform.ServerClient.Abstracts.Generation.Services.PropertyStrategies
{
    internal class DocuWareEnumListPropertyGenerationStrategy(PropertyGenerationType generationType) : PropertyGenerationStrategy(generationType)
    {
        protected override string GenerateGet(PropertyInfo property, string returnTypeName, string name)
        {
            string template = TemplateService.DocuWareEnumListPropertyGetTemplate;
            return GenerateFromTemplate(template, returnTypeName, name);
        }

        protected override string GenerateGetSet(PropertyInfo property, string returnTypeName, string name)
        {
            string template = TemplateService.DocuWareEnumListPropertyGetSetTemplate;
            return GenerateFromTemplate(template, returnTypeName, name);
        }

        private static string GenerateFromTemplate(string template, string returnTypeName, string name)
        {
            return template.Replace("{type}", $"DocuWare.Platform.ServerClient.{returnTypeName[5..^1]}")
                           .Replace("{name}", name)
                           .Replace("{targetType}", returnTypeName[5..^1])
                           .Replace("{interfaceType}", returnTypeName);
        }
    }
}

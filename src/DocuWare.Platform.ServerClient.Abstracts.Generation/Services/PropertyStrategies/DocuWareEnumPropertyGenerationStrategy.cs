using System.Reflection;
using DocuWare.Platform.ServerClient.Abstracts.Generation.Extensions;
using DocuWare.Platform.ServerClient.Abstracts.Generation.Templates;
using DocuWare.Platform.ServerClient.Abstracts.Generation.Wrapper;

namespace DocuWare.Platform.ServerClient.Abstracts.Generation.Services.PropertyStrategies
{
    internal class DocuWareEnumPropertyGenerationStrategy(PropertyGenerationType generationType) : PropertyGenerationStrategy(generationType)
    {
        protected override string GenerateGet(PropertyInfo property, string returnTypeName, string name)
        {
            string template = TemplateService.DocuWareEnumPropertyGetTemplate;
            return template.Replace("{type}", returnTypeName)
                           .Replace("{name}", name);
        }

        protected override string GenerateGetSet(PropertyInfo property, string returnTypeName, string name)
        {
            TypeDef typeDefinition = property.PropertyType.GetTypeDefinition();

            string template = TemplateService.DocuWareEnumPropertyGetSetTemplate;
            return template.Replace("{type}", returnTypeName)
                           .Replace("{targetType}", typeDefinition.FullName)
                           .Replace("{name}", name);
        }
    }
}

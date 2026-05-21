using System.Reflection;
using DocuWare.Platform.ServerClient.Abstracts.Generation.Templates;

namespace DocuWare.Platform.ServerClient.Abstracts.Generation.Services.PropertyStrategies
{
    internal class DocuWareArrayPropertyGenerationStrategy(PropertyGenerationType generationType) : PropertyGenerationStrategy(generationType)
    {
        protected override string GenerateGet(PropertyInfo property, string returnTypeName, string name)
        {
            string template = TemplateService.DocuWareArrayPropertyGetTemplate;
            return template.Replace("{type}", returnTypeName)
                           .Replace("{name}", name)
                           .Replace("{targetType}", returnTypeName[1..])
                           .Replace("{baseTargetType}", returnTypeName[1..^2]);
        }

        protected override string GenerateGetSet(PropertyInfo property, string returnTypeName, string name)
        {
            throw new NotImplementedException();
        }
    }
}

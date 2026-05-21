using System.Reflection;
using DocuWare.Platform.ServerClient.Abstracts.Generation.Templates;

namespace DocuWare.Platform.ServerClient.Abstracts.Generation.Services.PropertyStrategies
{
    internal class DoubleNestedDocuWareListPropertyGenerationStrategy(PropertyGenerationType generationType) : PropertyGenerationStrategy(generationType)
    {
        protected override string GenerateGet(PropertyInfo property, string returnTypeName, string name)
        {
            throw new NotImplementedException();
        }

        // TODO replace magic numbers with constants or a more robust way to determine the type names
        protected override string GenerateGetSet(PropertyInfo property, string returnTypeName, string name)
        {
            string template = TemplateService.DoubleNestedDocuWareListPropertyGetSetTemplate;
            return template.Replace("{returnType}", returnTypeName[10..^2])
                           .Replace("{name}", name)
                           .Replace("{type}", returnTypeName[11..^2]);
        }
    }
}

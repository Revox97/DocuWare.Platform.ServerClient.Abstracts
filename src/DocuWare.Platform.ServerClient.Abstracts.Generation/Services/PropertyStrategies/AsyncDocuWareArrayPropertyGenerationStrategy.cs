using System.Reflection;

namespace DocuWare.Platform.ServerClient.Abstracts.Generation.Services.PropertyStrategies
{
    internal class AsyncDocuWareArrayPropertyGenerationStrategy(PropertyGenerationType generationType) : PropertyGenerationStrategy(generationType)
    {
        private readonly string _getTemplate = @"       public {type} {name} => Task.Run(async () => (await Obj.{name}).ToList().Select(o => ({targetType})new {baseTargetType}(o)).ToArray());";

        protected override string GenerateGet(PropertyInfo property, string returnTypeName, string name)
        {
            return _getTemplate.Replace("{type}", returnTypeName)
                           .Replace("{name}", name)
                           .Replace("{targetType}", returnTypeName[5..^3])
                           .Replace("{baseTargetType}", returnTypeName[6..^3]);
        }

        protected override string GenerateGetSet(PropertyInfo property, string returnTypeName, string name)
        {
            throw new NotSupportedException();
        }
    }
}

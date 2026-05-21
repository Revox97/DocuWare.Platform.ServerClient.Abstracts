using System.Reflection;

namespace DocuWare.Platform.ServerClient.Abstracts.Generation.Services.PropertyStrategies
{
    internal class DefaultPropertyGenerationStrategy(PropertyGenerationType generationType) : PropertyGenerationStrategy(generationType)
    {
        private readonly string _getTemplate = @"        public {type} {name} => Obj.{name};";
        private readonly string _getSetTemplate = @"        public {type} {name}
        {
            get => Obj.{name};
            set => Obj.{name} = value;
        }";

        protected override string GenerateGet(PropertyInfo property, string returnTypeName, string name)
        {
            return _getTemplate.Replace("{type}", returnTypeName)
                               .Replace("{name}", name);
        }

        protected override string GenerateGetSet(PropertyInfo property, string returnTypeName, string name)
        {
            return _getSetTemplate.Replace("{type}", returnTypeName)
                                  .Replace("{name}", name);
        }
    }
}

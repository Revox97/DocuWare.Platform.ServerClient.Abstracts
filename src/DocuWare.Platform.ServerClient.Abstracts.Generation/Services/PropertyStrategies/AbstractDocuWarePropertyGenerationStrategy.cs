using System.Reflection;

namespace DocuWare.Platform.ServerClient.Abstracts.Generation.Services.PropertyStrategies
{
    internal class AbstractDocuWarePropertyGenerationStrategy(PropertyGenerationType generationType) : PropertyGenerationStrategy(generationType)
    {
        private readonly string _getSetTemplate = @"        public {type} {name}
        {
            get
            {
                Type type = Obj.{name}.GetType();
                return type.GetConstructor(BindingFlags.Public, [typeof(SDK.{targetType})]).Invoke([Obj.{name}]) as {type};
            }
            set
            {
                Type type = value.GetType();

                PropertyInfo objPropertyInfo = type.GetProperty(""Obj"");
                SDK.{targetType} obj = objPropertyInfo.GetValue(value) as SDK.{targetType};

                Obj.{name} = obj;
            }
        }
";

        protected override string GenerateGet(PropertyInfo property, string returnTypeName, string name)
        {
            throw new NotImplementedException();
        }

        protected override string GenerateGetSet(PropertyInfo property, string returnTypeName, string name)
        {
            return _getSetTemplate.Replace("{type}", returnTypeName)
                           .Replace("{name}", name)
                           .Replace("{targetType}", returnTypeName[1..]);
        }
    }
}

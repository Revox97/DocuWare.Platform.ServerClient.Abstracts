using System.Reflection;
using DocuWare.Platform.ServerClient.Abstracts.Generation.Templates;

namespace DocuWare.Platform.ServerClient.Abstracts.Generation.Services.PropertyStrategies
{
    internal class AbstractDocuWareListPropertyGenerationStrategy(PropertyGenerationType generationType) : PropertyGenerationStrategy(generationType)
    {
        private readonly string _getTemplate = @"        public {type} {name}
        {
            get
            {
                List<{interfaceType}> fields = [];

                foreach(SDK.{targetType} formField in Obj.Fields)
                {
                    Type type = formField.GetType();
                    fields.Add(type.GetConstructor(BindingFlags.Public, [typeof(SDK.{targetType})]).Invoke([formField]) as IWebFormControl);
                }

                return fields;
            }
        }";
        private readonly string _getSetTemplate = @"        public {type} {name}
        {
            get
            {
                List<{interfaceType}> fields = [];

                foreach(SDK.{targetType} formField in Obj.{name})
                {
                    Type type = formField.GetType();
                    fields.Add(type.GetConstructor(BindingFlags.Public, [typeof(SDK.{targetType})]).Invoke([formField]) as {interfaceType});
                }

                return fields;
            }
            set
            {
                List<SDK.{targetType}> fields = [];

                foreach({targetType} formField in value)
                {
                    Type type = formField.GetType();

                    PropertyInfo objPropertyInfo = type.GetProperty(""Obj"");
                    SDK.{targetType} obj = objPropertyInfo.GetValue(formField) as SDK.{targetType};

                    fields.Add(obj);
                }

                Obj.{name} = fields;
            }
        }";

        protected override string GenerateGet(PropertyInfo property, string returnTypeName, string name)
        {
            return GenerateFromTemplate(_getTemplate, returnTypeName, name);
        }

        protected override string GenerateGetSet(PropertyInfo property, string returnTypeName, string name)
        {
            string template = TemplateService.AbstractDocuWareListPropertyGetSetTemplate;
            return GenerateFromTemplate(_getSetTemplate, returnTypeName, name);
        }

        private static string GenerateFromTemplate(string template, string returnTypeName, string name)
        {
            return template.Replace("{type}", returnTypeName)
                           .Replace("{name}", name)
                           .Replace("{targetType}", returnTypeName[6..^1])
                           .Replace("{interfaceType}", returnTypeName[5..^1]);
        }
    }
}

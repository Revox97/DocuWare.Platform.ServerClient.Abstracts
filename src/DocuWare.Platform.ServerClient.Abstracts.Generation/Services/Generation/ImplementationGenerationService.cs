using System.Reflection;
using System.Text;
using DocuWare.Platform.ServerClient.Abstracts.Generation.Contracts;
using DocuWare.Platform.ServerClient.Abstracts.Generation.Extensions;
using DocuWare.Platform.ServerClient.Abstracts.Generation.Templates;

// TODO Handle interface parameters in actual calls
// TODO Handle actual type instead of interface

namespace DocuWare.Platform.ServerClient.Abstracts.Generation.Services.Generation
{
    internal class ImplementationGenerationService : IGenerationService
    {
        public void Generate(Type type)
        {
            Console.WriteLine($"Generating {type.Name}.cs");

            string template = File.ReadAllText("Templates/ImplementationTemplate.tmp");
            template = template.Replace("{0}", type.Name).Replace("{1}", $"I{type.Name}");

            string propertyList = GenerateProperties(type);
            string methodList = GenerateMethods(type);

            string result = propertyList + (methodList != string.Empty ? StringConstants.LineEnding : string.Empty) + methodList;

            template = template.Replace("{2}", result);
            using FileStream fStream = File.Create(Path.Combine(Paths.GenerationFolder, $"{type.Name}.g.cs"));
            fStream.Write(Encoding.UTF8.GetBytes(template ?? string.Empty));
        }

        private static string GenerateProperties(Type type)
        {
            PropertyInfo[] properties = type.GetProperties();
            string propertyList = string.Empty;

            for (int i = 0; i < properties.Length; i++)
                GenerateProperty(properties[i], ref propertyList);

            return propertyList;
        }

        private static void GenerateProperty(PropertyInfo property, ref string propertyList)
        {
            string typeName = property.PropertyType.GetParsedName();
            bool isDocuWareType;

            if (typeName.StartsWith("List<"))
            {
                Type[] subTypes = property.PropertyType.GetSubTypes();
                isDocuWareType = subTypes[0].IsDocuWareType();
            }
            else
            {
                isDocuWareType = property.PropertyType.IsDocuWareType();
            }

            string name = property.Name;
            bool hasSetter = property.GetSetMethod() is not null;
            propertyList += $"{StringConstants.LineEnding}{StringConstants.LineEndingWithTwoTabs}";

            if (isDocuWareType)
            {
                if (!hasSetter)
                {
                    if (typeName.StartsWith("List<"))
                        propertyList += $"public {typeName} {name} => Obj.{name}.Select(x => new {typeName[6..^1]}(x) as {typeName[5..^1]}).ToList();";
                    else 
                        propertyList += $"public {typeName} {name} => new {typeName[1..]}(Obj.{name});";
                }
                else
                {
                    if (typeName.StartsWith("List<"))
                        propertyList += $"public {typeName} {name}{StringConstants.LineEndingWithTwoTabs}{{{StringConstants.LineEndingWithThreeTabs}get => Obj.{name}.Select(x => new {typeName[6..^1]}(x) as {typeName[5..^1]}).ToList();{StringConstants.LineEndingWithThreeTabs}set => Obj.{name} = value.Select(x => (({typeName[6..^1]})x).Obj).ToList();{StringConstants.LineEndingWithTwoTabs}}}";
                    else 
                        propertyList += $"public {typeName} {name}{StringConstants.LineEndingWithTwoTabs}{{{StringConstants.LineEndingWithThreeTabs}get => new {typeName[1..]}(Obj.{name});{StringConstants.LineEndingWithThreeTabs}set => Obj.{name} = (({typeName[1..]})value).Obj;{StringConstants.LineEndingWithTwoTabs}}}";
                }
            }
            else
            {
                if (!hasSetter)
                    propertyList += $"public {typeName} {name} => Obj.{name};";
                else
                    propertyList += $"public {typeName} {name}{StringConstants.LineEndingWithTwoTabs}{{{StringConstants.LineEndingWithThreeTabs}get => Obj.{name};{StringConstants.LineEndingWithThreeTabs}set => Obj.{name} = value;{StringConstants.LineEndingWithTwoTabs}}}";
            }
        }

        private static string GenerateMethods(Type type)
        {
            MethodInfo[] methods = [.. type.GetMethods(BindingFlags.Instance | BindingFlags.Public).Where(m => !m.IsSpecialName)];

            string methodList = string.Empty;

            for (int i = 0; i < methods.Length; i++)
            {
                MethodInfo method = methods[i];

                if (method.DeclaringType != type)
                    continue;

                string returnTypeName = method.ReturnType.GetParsedName();

                if (returnTypeName.StartsWith("Task"))
                    methodList += $"{StringConstants.LineEnding}{GenerateAsynchronous(method)}";
                else
                    methodList += $"{StringConstants.LineEnding}{GenerateSynchronous(method)}";
            }

            return methodList;
        }

        private static string GenerateSynchronous(MethodInfo method)
        {
            string returnTypeName = method.ReturnType.GetParsedName();
            bool isDocuWareType = method.ReturnType.IsDocuWareType();
            string parameters = method.GetParsedParameterDefinitions();
            string paramsToSent = method.GetParsedParameters();

            return isDocuWareType
                ? TemplateService.SyncDocuWareMethod.Replace("{0}", returnTypeName).Replace("{1}", method.Name).Replace("{2}", parameters).Replace("{3}", returnTypeName[1..]).Replace("{4}", paramsToSent)
                : $"\t\tpublic async {returnTypeName} {method.Name}({parameters}) => Obj.{method.Name}({paramsToSent});";
        }

        private static string GenerateAsynchronous(MethodInfo method)
        {
            string returnTypeName = method.ReturnType.GetParsedName();
            string parameters = method.GetParsedParameterDefinitions();
            string paramsToSent = method.GetParsedParameters();
            string[] typeList = returnTypeName.Split('<');
            string baseName = returnTypeName.StartsWith("Task<DeserializedHttpResponse<")
                ? typeList[typeList.Length - 1][..^2]
                : returnTypeName;

            // TODO Find a working and better way to handle nested dw types
            bool isDocuWareType = Type.GetType($"DocuWare.Platform.ServerClient.{baseName[1..]}")?.IsDocuWareType() ?? false;
            baseName = isDocuWareType ? baseName[1..] : baseName;

            return returnTypeName.Contains("DeserializedHttpResponse<")
                ? TemplateService.AsyncDocuWareMethod.Replace("{0}", returnTypeName).Replace("{1}", method.Name).Replace("{2}", parameters).Replace("{3}", baseName).Replace("{4}", paramsToSent)
                : $"\t\tpublic async {returnTypeName} {method.Name}({parameters}) => await Obj.{method.Name}({paramsToSent});";
        }
    }
}

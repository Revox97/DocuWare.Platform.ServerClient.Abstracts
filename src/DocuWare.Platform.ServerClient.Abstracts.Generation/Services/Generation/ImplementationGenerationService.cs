using System.Reflection;
using System.Text;
using System.Xml.Serialization;
using DocuWare.Platform.ServerClient.Abstracts.Generation.Contracts;
using DocuWare.Platform.ServerClient.Abstracts.Generation.Extensions;
using DocuWare.Platform.ServerClient.Abstracts.Generation.Templates;
using DocuWare.Platform.ServerClient.Abstracts.Generation.Wrapper;

// TODO Handle interface parameters in actual calls
// TODO Handle actual type instead of interface

namespace DocuWare.Platform.ServerClient.Abstracts.Generation.Services.Generation
{
    internal class ImplementationGenerationService : IGenerationService
    {
        public void Generate(Type type)
        {
            Console.WriteLine($"Generating {type.Name}.cs");

            string template = File.ReadAllText("Templates/Implementation.template");
            template = template.Replace("{0}", type.Name).Replace("{1}", $"I{type.Name}");

            string propertyList = GenerateProperties(type);
            string methodList = GenerateMethods(type);

            string result = propertyList + methodList;

            template = template.Replace("{2}", result);
            using FileStream fStream = File.Create(Path.Combine(Paths.GenerationFolder, $"{type.Name}.g.cs"));
            fStream.Write(Encoding.UTF8.GetBytes(template ?? string.Empty));
        }

        private static string GenerateProperties(Type type)
        {
            PropertyInfo[] properties = [.. type.GetProperties(BindingFlags.Instance | BindingFlags.Public).Where(p => p.CustomAttributes.Any(a => a.AttributeType != typeof(XmlIgnoreAttribute)))];
            string propertyList = string.Empty;

            for (int i = 0; i < properties.Length; i++)
                GenerateProperty(properties[i], ref propertyList);

            return propertyList;
        }

        private static void GenerateProperty(PropertyInfo property, ref string propertyList)
        {
            TypeDef typeDefinition = property.PropertyType.GetTypeDefinition();
            string typeName = typeDefinition.GetReturnTypeName();
            bool isList = typeDefinition.Category is TypeCategory.List;

            bool isDocuWareType = isList
                ? typeDefinition.NestedType is not null && typeDefinition.NestedType.Category is TypeCategory.DocuWare
                : typeDefinition.Category is TypeCategory.DocuWare;

            string name = property.Name;
            bool hasSetter = property.GetSetMethod() is not null;
            propertyList += $"{StringConstants.LineEnding}{StringConstants.LineEnding}";

            if (isDocuWareType)
            {
                if (hasSetter)
                {
                    if (isList)
                        propertyList += TemplateService.GetDocuWareListGetSetPropertyImplementation(typeName, name);
                    else
                        propertyList += TemplateService.GetDocuWareGetSetPropertyImplementation(typeName, name);
                }
                else
                {
                    if (isList)
                        propertyList += TemplateService.GetDocuWareListGetPropertyImplementation(typeName, name);
                    else
                        propertyList += TemplateService.GetDocuWareGetPropertyImplementation(typeName, name);
                }

                return;
            }

            if (hasSetter)
                propertyList += TemplateService.GetNormalGetSetPropertyImplementation(typeName, name);
            else
                propertyList += TemplateService.GetNormalGetPropertyImplementation(typeName, name);
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
                methodList += $"{StringConstants.LineEnding}{StringConstants.LineEnding}";

                if (returnTypeName.StartsWith("Task"))
                    methodList += $"{GenerateAsynchronous(method)}";
                else
                    methodList += $"{GenerateSynchronous(method)}";
            }

            return methodList;
        }

        private static string GenerateSynchronous(MethodInfo method)
        {
            TypeDef typeDef = method.ReturnType.GetTypeDefinition();
            string returnTypeName = typeDef.GetReturnTypeName();
            string typeName = typeDef.GetTypeName();
            bool isDocuWareType = typeDef.Category is TypeCategory.DocuWare;
            string parameters = method.GetParsedParameterDefinitions();
            string paramsToSent = method.GetParsedParameters();

            return isDocuWareType
                ? TemplateService.SyncDocuWareMethod.Replace("{0}", returnTypeName).Replace("{1}", method.Name).Replace("{2}", parameters).Replace("{3}", typeName).Replace("{4}", paramsToSent)
                : $"\t\tpublic {returnTypeName} {method.Name}({parameters}) => Obj.{method.Name}({paramsToSent});";
        }

        private static string GenerateAsynchronous(MethodInfo method)
        {
            string parameters = method.GetParsedParameterDefinitions();
            string paramsToSent = method.GetParsedParameters();

            TypeDef returnType = method.ReturnType.GetTypeDefinition();
            string typeName = returnType.GetTypeName();
            string returnTypeName = returnType.GetReturnTypeName();

            TypeDef? innerMostChild = returnType.NestedType;
            while (innerMostChild is not null && innerMostChild.NestedType is not null)
                innerMostChild = innerMostChild.NestedType;

            bool isDwType = innerMostChild is not null && innerMostChild.Category is TypeCategory.DocuWare;

            return isDwType && returnTypeName.Contains("DeserializedHttpResponse<")
                ? GenerateAsyncDeserializedHttpResponseMethod(returnType, typeName, returnTypeName, method, parameters, paramsToSent)
                : $"\t\tpublic async {returnTypeName} {method.Name}({parameters}) => await Obj.{method.Name}({paramsToSent});";
        }

        private static string GenerateAsyncDeserializedHttpResponseMethod(TypeDef returnType, string typeName, string returnTypeName, MethodInfo method, string parameters, string paramsToSent)
        {
            string result = TemplateService.AsyncDocuWareMethod.Replace("{0}", returnTypeName).Replace("{1}", method.Name).Replace("{2}", parameters).Replace("{4}", paramsToSent);

            TypeDef? innerMostChild = returnType.NestedType;
            while (innerMostChild is not null && innerMostChild.NestedType is not null)
                innerMostChild = innerMostChild.NestedType;

            if (innerMostChild is not null)
            {
                result = result.Replace("{3}", innerMostChild.GetTypeName());

                if (innerMostChild.Category is TypeCategory.DocuWare)
                {
                    result = result.Replace("{5}", $"DeserializedHttpResponse<DocuWare.Platform.ServerClient.{innerMostChild.GetTypeName()}>");
                    result = result.Replace("{6}", $"I{innerMostChild.GetTypeName()}");
                }
                else
                {
                    result = result.Replace("{5}", $"DeserializedHttpResponse<{innerMostChild.GetTypeName()}>");
                    result = result.Replace("{6}", innerMostChild.GetTypeName());
                }
            }
            else
            {
                result = result.Replace("{3}", typeName);
                result = result.Replace("{5}", $"DeserializedHttpResponse<{returnType.GetTypeName()}>");
                result = result.Replace("{6}", returnType.GetTypeName());
            }

            return result;
        }
    }
}

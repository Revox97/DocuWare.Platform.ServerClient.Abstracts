using System.Reflection;
using DocuWare.Platform.ServerClient.Abstracts.Generation.Wrapper;

namespace DocuWare.Platform.ServerClient.Abstracts.Generation.Extensions
{
    internal static class MethodInfoExtensions
    {
        internal static string GetParsedParameterDefinitions(this MethodInfo method)
        {
            ParameterInfo[] parameters = method.GetParameters();
            string result = string.Empty;

            for (int i = 0; i < parameters.Length; i++)
            {
                ParameterInfo parameter = parameters[i];
                TypeDef paramTypeDef = parameter.ParameterType.GetTypeDefinition();

                string returnTypeName = paramTypeDef.GetReturnTypeName(); 

                string parsedParameter = parameter.HasDefaultValue
                    ? $"{(returnTypeName.EndsWith('?') ? returnTypeName[..^1] : returnTypeName)}? {parameter.Name} = {(parameter.DefaultValue is null ? "null" : parameter.DefaultValue)}"
                    : $"{paramTypeDef.GetReturnTypeName()} {parameter.Name}";

                if (i == 0)
                    result += parsedParameter;
                else
                    result += $", {parsedParameter}";
            }

            return result;
        }

        internal static string GetParsedParameters(this MethodInfo method)
        {
            ParameterInfo[] parameters = method.GetParameters();
            string result = string.Empty;

            for (int i = 0; i < parameters.Length; i++)
            {
                ParameterInfo parameter = parameters[i];
                TypeDef paramType = parameter.ParameterType.GetTypeDefinition();

                string parsedParameter = paramType.Category == TypeCategory.DocuWare
                    ? $"(({paramType.GetTypeName()}){parameter.Name}).Obj"
                    : parameter.GetParsedParameters();

                if (i == 0)
                    result += parsedParameter;
                else
                    result += $", {parsedParameter}";
            }

            return result;
        }
    }
}

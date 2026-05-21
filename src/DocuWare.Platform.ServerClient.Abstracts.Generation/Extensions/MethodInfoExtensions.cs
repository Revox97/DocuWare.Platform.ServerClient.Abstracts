using System.Reflection;
using DocuWare.Platform.ServerClient.Abstracts.Generation.Wrapper;

namespace DocuWare.Platform.ServerClient.Abstracts.Generation.Extensions
{
    internal static class MethodInfoExtensions
    {
        private const int FirstParameterIndex = 0;

        internal static string GetParsedParameterDefinitions(this MethodInfo method)
        {
            ParameterInfo[] parameters = method.GetParameters();
            string parameterDefinitions = string.Empty;

            for (int i = 0; i < parameters.Length; i++)
            {
                ParameterInfo parameter = parameters[i];
                TypeDef paramTypeDef = parameter.ParameterType.GetTypeDefinition();

                string returnTypeName = paramTypeDef.GetReturnTypeName();

                string parsedParameter = parameter.HasDefaultValue
                    ? CreateParameterWithDefaultValue(returnTypeName, parameter)
                    : CreateParameterWithoutDefaultValue(paramTypeDef, parameter);

                bool isFirstParameter = i == FirstParameterIndex;
                parameterDefinitions += isFirstParameter ? parsedParameter : $", {parsedParameter}";
            }

            return parameterDefinitions;
        }

        private static string CreateParameterWithDefaultValue(string returnTypeName, ParameterInfo parameter)
        {
            string nullableReturnTypeName = returnTypeName.EndsWith('?') ? returnTypeName[..^1] : returnTypeName;
            string defaultValue = parameter.DefaultValue is null ? "null" : parameter.DefaultValue.ToString() ?? "null";
            return $"{nullableReturnTypeName}? {parameter.Name} = {defaultValue}";
        }

        private static string CreateParameterWithoutDefaultValue(TypeDef paramTypeDef, ParameterInfo parameter)
        {
            return $"{paramTypeDef.GetReturnTypeName()} {parameter.Name}";
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

                bool isFirstParameter = i == FirstParameterIndex;

                result += isFirstParameter
                    ? parsedParameter
                    : $", {parsedParameter}";
            }

            return result;
        }
    }
}

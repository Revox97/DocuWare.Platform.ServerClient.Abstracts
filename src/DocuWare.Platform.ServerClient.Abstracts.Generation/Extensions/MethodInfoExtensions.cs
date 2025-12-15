using System.Reflection;

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
                string parsedParameter = parameter.GetParsedParameterDefinitions();

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
                string parsedParameter = parameter.GetParsedParameters();

                // TODO Handle docuware interface parameters in actual calls
                if (i == 0)
                    result += parsedParameter;
                else
                    result += $", {parsedParameter}";
            }

            return result;
        }
    }
}

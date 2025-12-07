using System.Reflection;

namespace DocuWare.Platform.ServerClient.Abstracts.Generation.Extensions
{
    internal static class MethodInfoExtensions
    {
        internal static string GetParsedParameters(this MethodInfo method)
        {
            ParameterInfo[] parameters = method.GetParameters();
            string result = string.Empty;

            for (int i = 0; i < parameters.Length; i++)
            {
                ParameterInfo parameter = parameters[i];
                string parsedParameter = parameter.GetParsedParameter();

                if (i == 0)
                    result += parsedParameter;
                else
                    result += $", {parsedParameter}";
            }

            return result;
        }
    }
}

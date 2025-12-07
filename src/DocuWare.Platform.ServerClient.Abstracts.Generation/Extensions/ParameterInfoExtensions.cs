using System.Reflection;

namespace DocuWare.Platform.ServerClient.Abstracts.Generation.Extensions
{
    internal static class ParameterInfoExtensions
    {
        internal static string GetParsedParameterDefinitions(this ParameterInfo parameter)
        {
            string type = parameter.ParameterType.GetParsedName();
            string defaultValue = GetDefaultValue(parameter);

            if (defaultValue.EndsWith("null") && !type.EndsWith('?'))
                type += '?';

            return $"{type} {parameter.Name}{defaultValue}";
            
        }

        private static string GetDefaultValue(ParameterInfo parameter)
        {
            if (parameter.HasDefaultValue)
            {
                object? defaultValue = parameter.DefaultValue;
                if (defaultValue is null)
                    return " = null";

                if (defaultValue is string)
                    return $" = \"{defaultValue}\"";

                if (defaultValue is bool)
                    return $" = {defaultValue.ToString()!.ToLower()}";
                
                return $" = {defaultValue}";
            }

            return string.Empty;
        }

        internal static string GetParsedParameters(this ParameterInfo parameter)
        {
            return parameter.Name ?? string.Empty;
        }
    }
}

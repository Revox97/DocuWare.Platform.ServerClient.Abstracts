using DocuWare.Platform.ServerClient.Abstracts.Generation.Services;

namespace DocuWare.Platform.ServerClient.Abstracts.Generation.Extensions
{
    internal static class TypeExtensions
    {
        // TODO implement
        // TODO create type to contain all comments
        public static List<object> GetDocumentationComments(this Type t)
        {
            DocumentationCommentsService.GetDocumentationComments(t);
            throw new NotImplementedException();
        }

        public static string GetParsedName(this Type t)
        {
            string name = t.Name;

            if (name == "T")
                return name;

            if (t.IsEnum)
            {
                return t.IsDocuWareType()
                    ? $"DocuWare.Platform.ServerClient.{name}"
                    : name;
            }

            if (t.IsPrimitive || t == typeof(string) || t == typeof(void) || t == typeof(object))
                return t.GetParsedPrimitiveType();

            if (t.IsGenericType)
            {
                if (name.StartsWith("Nullable"))
                {
                    string subTypeName = t.GenericTypeArguments[0].GetParsedName();
                    return $"{subTypeName}?";
                }

                string subType = t.GetParsedSubTypes();
                return $"{name[..name.IndexOf('`')]}<{subType}>";
            }

            return t.IsClass && t.IsDocuWareType()
                ? $"I{name}"
                : name;
        }

        internal static string GetParsedSubTypes(this Type t)
        {
            string result = string.Empty;
            Type[] subTypes = t.GenericTypeArguments;

            for (int i = 0; i < subTypes.Length; i++)
            {
                if (i == 0)
                    result += subTypes[i].GetParsedName();
                else
                    result += $",{subTypes[i].GetParsedName}";
            }

            return result;
        }

        internal static Type[] GetSubTypes(this Type t)
        {
            return t.GenericTypeArguments;
        }

        internal static bool IsDocuWareType(this Type t, bool checkForEnum = false)
        {
            return t.Namespace is not null && t.Namespace.StartsWith("DocuWare.Platform.ServerClient") && (!checkForEnum || !t.IsEnum);
        }

        private static string GetParsedPrimitiveType(this Type t)
        {
            return t.Name.ToLower() switch
            {
                "boolean" => "bool",
                "int16" => "byte",
                "int32" => "int",
                "int64" => "long",
                "uint16" => "ubyte",
                "uint32" => "uint",
                "uint64" => "ulong",
                "double" => "double",
                "single" => "float",
                "object" => "object",
                "void" => "void",
                "string" => "string",
                _ => "!!!UNKNOWN_PRIMITIVE" // TODO Fallback during development -> Change to return name
            };
        }
    }
}

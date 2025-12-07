namespace DocuWare.Platform.ServerClient.Abstracts.Generation.Extensions
{
    internal static class TypeExtensions
    {
        public static string GetParsedName(this Type t)
        {
            string name = t.Name;

            if (name == "T")
                return name;

            if (t.IsPrimitive || t == typeof(string) || t == typeof(void))
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

        private static string GetParsedSubTypes(this Type t)
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

        private static bool IsDocuWareType(this Type t)
        {
            return t.Namespace is not null && t.Namespace.StartsWith("DocuWare.Platform.ServerClient");
        }

        private static string GetParsedPrimitiveType(this Type t)
        {
            if (t == typeof(string) || t == typeof(void))
                return t.Name.ToLower();

            string name = t.Name.ToLower();

            return name.ToLower() switch
            {
                "boolean" => "bool",
                "int16" => "byte",
                "int32" => "int",
                "int64" => "long",
                _ => "!!!UNKNOWN_PRIMITIVE" // TODO Fallback during development -> Change to return name
            };
        }
    }
}

namespace DocuWare.Platform.ServerClient.Abstracts.Generation.Templates
{
    internal static class TemplateService
    {
        public static string SyncDocuWareMethod
        {
            get
            {
                return field ??= GetFileContentsWithoutLastLine("Templates/SyncDocuWareMethodTemplate.tmp");
            }
        } = null!;

        public static string AsyncDocuWareMethod
        {
            get
            {
                return field ??= GetFileContentsWithoutLastLine("Templates/AsyncDocuWareMethodTemplate.tmp");
            }
        } = null!;

        public static string PropertyGet
        {
            get
            {
                return field ??= GetFileContentsWithoutLastLine("Templates/PropertyGetTemplate.tmp");
            }
        } = null!;

        public static string PropertyGetSet
        {
            get
            {
                return field ??= GetFileContentsWithoutLastLine("Templates/PropertyGetSetTemplate.tmp");
            }
        } = null!;

        public static string DocuWarePropertyGet
        {
            get
            {
                return field ??= GetFileContentsWithoutLastLine("Templates/DocuWarePropertyGetTemplate.tmp");
            }
        } = null!;

        public static string DocuWarePropertyGetSet
        {
            get
            {
                return field ??= GetFileContentsWithoutLastLine("Templates/DocuWarePropertyGetSetTemplate.tmp");
            }
        } = null!;

        public static string DocuWareListPropertyGet
        {
            get
            {
                return field ??= GetFileContentsWithoutLastLine("Templates/DocuWareListPropertyGetTemplate.tmp");
            }
        } = null!;

        public static string DocuWareListPropertyGetSet
        {
            get
            {
                return field ??= GetFileContentsWithoutLastLine("Templates/DocuWareListPropertyGetSetTemplate.tmp");
            }
        } = null!;

        internal static string GetNormalGetPropertyImplementation(string type, string name)
        {
            return PropertyGet.Replace("{type}", type).Replace("{name}", name);
        }

        internal static string GetNormalGetSetPropertyImplementation(string type, string name)
        {
            return PropertyGetSet.Replace("{type}", type).Replace("{name}", name);
        }

        internal static string GetDocuWareGetPropertyImplementation(string type, string name)
        {
            return DocuWarePropertyGet.Replace("{type}", type).Replace("{name}", name).Replace("{targetType}", type[1..]);
        }

        internal static string GetDocuWareGetSetPropertyImplementation(string type, string name)
        {
            return DocuWarePropertyGetSet.Replace("{type}", type).Replace("{name}", name).Replace("{targetType}", type[1..]);
        }

        internal static string GetDocuWareListGetPropertyImplementation(string type, string name)
        {
            return DocuWareListPropertyGet.Replace("{type}", type).Replace("{name}", name).Replace("{targetType}", type[6..^1]).Replace("{interfaceType}", type[5..^1]);
        }

        internal static string GetDocuWareListGetSetPropertyImplementation(string type, string name)
        {
            return DocuWareListPropertyGetSet.Replace("{type}", type).Replace("{name}", name).Replace("{targetType}", type[6..^1]).Replace("{interfaceType}", type[5..^1]);
        }

        private static string GetFileContentsWithoutLastLine(string path)
        {
            string fileContents = File.ReadAllText(path);
            return fileContents[..^2];
        }
    }
}

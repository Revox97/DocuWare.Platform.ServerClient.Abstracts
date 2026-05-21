namespace DocuWare.Platform.ServerClient.Abstracts.Generation.Templates
{
    internal static class TemplateService
    {
        public static string SyncDocuWareMethod
        {
            get
            {
                return field ??= GetFileContentsWithoutLastLine("Templates/SyncDocuWareMethod.template");
            }
        } = null!;

        public static string SyncDocuWareEnumMethod
        {
            get
            {
                return field ??= GetFileContentsWithoutLastLine("Templates/SyncDocuWareEnumMethod.template");
            }
        } = null!;

        public static string AsyncDocuWareMethod
        {
            get
            {
                return field ??= GetFileContentsWithoutLastLine("Templates/AsyncDocuWareMethod.template");
            }
        } = null!;

        public static string PropertyGetTemplate
        {
            get
            {
                return field ??= GetFileContentsWithoutLastLine("Templates/PropertyGet.template");
            }
        } = null!;

        public static string PropertyGetSetTemplate
        {
            get
            {
                return field ??= GetFileContentsWithoutLastLine("Templates/PropertyGetSet.template");
            }
        } = null!;

        public static string DocuWarePropertyGetTemplate
        {
            get
            {
                return field ??= GetFileContentsWithoutLastLine("Templates/DocuWarePropertyGet.template");
            }
        } = null!;

        public static string DocuWarePropertyGetSetTemplate
        {
            get
            {
                return field ??= GetFileContentsWithoutLastLine("Templates/DocuWarePropertyGetSet.template");
            }
        } = null!;

        public static string AbstractDocuWarePropertyGetSetTemplate
        {
            get
            {
                return field ??= GetFileContentsWithoutLastLine("Templates/AbstractDocuWarePropertyGetSet.template");
            }
        } = null!;

        public static string DocuWareListPropertyGetTemplate
        {
            get
            {
                return field ??= GetFileContentsWithoutLastLine("Templates/DocuWareListPropertyGet.template");
            }
        } = null!;

        public static string AbstractDocuWareListPropertyGetTemplate
        {
            get
            {
                return field ??= GetFileContentsWithoutLastLine("Templates/AbstractDocuWareListPropertyGet.template");
            }
        } = null!;

        public static string DocuWareListPropertyGetSetTemplate
        {
            get
            {
                return field ??= GetFileContentsWithoutLastLine("Templates/DocuWareListPropertyGetSet.template");
            }
        } = null!;

        public static string AbstractDocuWareListPropertyGetSetTemplate
        {
            get
            {
                return field ??= GetFileContentsWithoutLastLine("Templates/AbstractDocuWareListPropertyGetSet.template");
            }
        } = null!;

        public static string DoubleNestedDocuWareListPropertyGetSetTemplate
        {
            get
            {
                return field ??= GetFileContentsWithoutLastLine("Templates/DoubleNestedDocuWareListGetSetProperty.template");
            }
        } = null!;

        public static string DocuWareArrayPropertyGetTemplate
        {
            get
            {
                return field ??= GetFileContentsWithoutLastLine("Templates/PropertyArrayGet.template");
            }
        } = null!;

        public static string DocuWareAsyncArrayPropertyGetTemplate
        {
            get
            {
                return field ??= GetFileContentsWithoutLastLine("Templates/PropertyAsyncArrayGet.template");
            }
        } = null!;

        public static string DocuWareEnumListPropertyGetTemplate
        {
            get
            {
                return field ??= GetFileContentsWithoutLastLine("Templates/DocuWareEnumListPropertyGet.template");
            }
        } = null!;

        public static string DocuWareEnumListPropertyGetSetTemplate
        {
            get
            {
                return field ??= GetFileContentsWithoutLastLine("Templates/DocuWareEnumListPropertyGetSet.template");
            }
        } = null!;

        public static string DocuWareEnumPropertyGetTemplate
        {
            get
            {
                return field ??= GetFileContentsWithoutLastLine("Templates/DocuWareEnumPropertyGet.template");
            }
        } = null!;

        public static string DocuWareEnumPropertyGetSetTemplate
        {
            get
            {
                return field ??= GetFileContentsWithoutLastLine("Templates/DocuWareEnumPropertyGetSet.template");
            }
        } = null!;

        internal static string GetSyncDocuWareMethodImplementation(string returnType, string type, string name, string parameters, string parametersToSend)
        {
            return SyncDocuWareMethod.Replace("{0}", returnType).Replace("{1}", name).Replace("{2}", parameters).Replace("{3}", type).Replace("{4}", parametersToSend);
        }

        internal static string GetSyncDocuWareEnumMethodImplementation(string type, string name, string parameters, string parametersToSend)
        {
            return SyncDocuWareEnumMethod.Replace("{type}", type).Replace("{name}", name).Replace("{params}", parameters).Replace("{paramsToSend}", parametersToSend);
        }

        private static string GetFileContentsWithoutLastLine(string path)
        {
            string fileContents = File.ReadAllText(path);
            return fileContents[..^2];
        }
    }
}

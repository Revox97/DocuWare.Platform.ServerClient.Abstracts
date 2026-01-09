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

        public static string PropertyGet
        {
            get
            {
                return field ??= GetFileContentsWithoutLastLine("Templates/PropertyGet.template");
            }
        } = null!;

        public static string PropertyGetSet
        {
            get
            {
                return field ??= GetFileContentsWithoutLastLine("Templates/PropertyGetSet.template");
            }
        } = null!;

        public static string DocuWarePropertyGet
        {
            get
            {
                return field ??= GetFileContentsWithoutLastLine("Templates/DocuWarePropertyGet.template");
            }
        } = null!;

        public static string DocuWarePropertyGetSet
        {
            get
            {
                return field ??= GetFileContentsWithoutLastLine("Templates/DocuWarePropertyGetSet.template");
            }
        } = null!;

        public static string DocuWareListPropertyGet
        {
            get
            {
                return field ??= GetFileContentsWithoutLastLine("Templates/DocuWareListPropertyGet.template");
            }
        } = null!;

        public static string DocuWareListPropertyGetSet
        {
            get
            {
                return field ??= GetFileContentsWithoutLastLine("Templates/DocuWareListPropertyGetSet.template");
            }
        } = null!;

        public static string DoubleNestedDocuWareListPropertyGetSet
        {
            get
            {
                return field ??= GetFileContentsWithoutLastLine("Templates/DoubleNestedDocuWareListGetSetProperty.template");
            }
        } = null!;

        public static string DocuWareEnumListPropertyGet
        {
            get
            {
                return field ??= GetFileContentsWithoutLastLine("Templates/DocuWareEnumListPropertyGet.template");
            }
        } = null!;

        public static string DocuWareEnumListPropertyGetSet
        {
            get
            {
                return field ??= GetFileContentsWithoutLastLine("Templates/DocuWareEnumListPropertyGetSet.template");
            }
        } = null!;

        public static string DocuWareEnumPropertyGet
        {
            get
            {
                return field ??= GetFileContentsWithoutLastLine("Templates/DocuWareEnumPropertyGet.template");
            }
        } = null!;

        public static string DocuWareEnumPropertyGetSet
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

        internal static string GetDoubleNestedDocuWareListGetSetPropertyImplementation(string type, string name)
        {
            return DoubleNestedDocuWareListPropertyGetSet.Replace("{returnType}", type[10..^2]).Replace("{name}", name).Replace("{type}", type[11..^2]);
        }

        internal static string GetDocuWareEnumListGetPropertyImplementation(string type, string name)
        {
            return DocuWareEnumListPropertyGet.Replace("{type}", $"DocuWare.Platform.ServerClient.{type[5.. ^1]}").Replace("{name}", name).Replace("{targetType}", type[5..^1]).Replace("{interfaceType}", type);
        }

        internal static string GetDocuWareEnumListGetSetPropertyImplementation(string type, string name)
        {
            return DocuWareEnumListPropertyGetSet.Replace("{type}", $"DocuWare.Platform.ServerClient.{type[5.. ^1]}").Replace("{name}", name).Replace("{targetType}", type[5..^1]).Replace("{interfaceType}", type);
        }

        internal static string GetDocuWareEnumGetPropertyImplementation(string type, string name)
        {
            return DocuWareEnumPropertyGet.Replace("{type}", type).Replace("{name}", name);
        }

        internal static string GetDocuWareEnumGetSetPropertyImplementation(string type, string targetType, string name)
        {
            return DocuWareEnumPropertyGetSet.Replace("{type}", type).Replace("{targetType}", targetType).Replace("{name}", name);
        }

        private static string GetFileContentsWithoutLastLine(string path)
        {
            string fileContents = File.ReadAllText(path);
            return fileContents[..^2];
        }
    }
}

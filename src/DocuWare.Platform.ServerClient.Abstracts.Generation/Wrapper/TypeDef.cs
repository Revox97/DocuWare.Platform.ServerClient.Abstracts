using System.Text;

namespace DocuWare.Platform.ServerClient.Abstracts.Generation.Wrapper
{
    internal class TypeDef
    {
        internal string Name { get; set; } = string.Empty;
        internal string FullName { get; set; } = string.Empty;
        internal TypeCategory Category { get; set; }
        internal TypeDef? Parent { get; set; }
        internal TypeDef? NestedType { get; set; }

        internal string GetTypeName()
        {
            StringBuilder sb = new(Name);

            if (Category is TypeCategory.Generic && NestedType is not null)
                sb = sb.Replace("<T>", $"<{NestedType.GetTypeName()}>");

            return sb.ToString();
        }

        internal string GetReturnTypeName()
        {
            StringBuilder sb = new(Category is TypeCategory.DocuWare ? $"I{Name}" : Name);

            if (Category is TypeCategory.Generic or TypeCategory.List && NestedType is not null)
                sb = sb.Replace("<T>", $"<{NestedType.GetReturnTypeName()}>");

            return sb.ToString();
        }
    }

    internal enum TypeCategory
    {
        Primitive,
        DocuWare,
        Generic,
        List,
        Enum,
        Interface
    }
}

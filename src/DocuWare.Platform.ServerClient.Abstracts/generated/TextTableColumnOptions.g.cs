using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TextTableColumnOptions(DocuWare.Platform.ServerClient.TextTableColumnOptions obj) : ITextTableColumnOptions
    {
        internal DocuWare.Platform.ServerClient.TextTableColumnOptions Obj { get; } = obj;

        public int Length
        {
            get => Obj.Length;
            set => Obj.Length = value;
        }
    }
}

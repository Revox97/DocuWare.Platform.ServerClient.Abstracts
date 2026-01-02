using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TextHistoryFieldOptions(DocuWare.Platform.ServerClient.TextHistoryFieldOptions obj) : ITextHistoryFieldOptions
    {
        internal DocuWare.Platform.ServerClient.TextHistoryFieldOptions Obj { get; } = obj;

        public int Length
        {
            get => Obj.Length;
            set => Obj.Length = value;
        }
    }
}

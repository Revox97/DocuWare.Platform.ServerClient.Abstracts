using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TextColumn(DocuWare.Platform.ServerClient.TextColumn obj) : ITextColumn
    {
        internal DocuWare.Platform.ServerClient.TextColumn Obj { get; } = obj;

        public int Length
        {
            get => Obj.Length;
            set => Obj.Length = value;
        }
    }
}

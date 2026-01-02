using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentIndexFieldValue(DocuWare.Platform.ServerClient.DocumentIndexFieldValue obj) : IDocumentIndexFieldValue
    {
        internal DocuWare.Platform.ServerClient.DocumentIndexFieldValue Obj { get; } = obj;

        public object Item
        {
            get => Obj.Item;
            set => Obj.Item = value;
        }
    }
}

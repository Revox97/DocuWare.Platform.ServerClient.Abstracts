using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentIndexFieldValueBase(DocuWare.Platform.ServerClient.DocumentIndexFieldValueBase obj) : IDocumentIndexFieldValueBase
    {
        internal DocuWare.Platform.ServerClient.DocumentIndexFieldValueBase Obj { get; } = obj;

        public object Item
        {
            get => Obj.Item;
            set => Obj.Item = value;
        }
    }
}

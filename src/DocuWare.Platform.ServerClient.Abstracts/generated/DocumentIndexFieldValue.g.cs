using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentIndexFieldValue(SDK.DocumentIndexFieldValue obj) : IDocumentIndexFieldValue
    {
        internal SDK.DocumentIndexFieldValue Obj { get; } = obj;

        public object Item
        {
            get => Obj.Item;
            set => Obj.Item = value;
        }
    }
}

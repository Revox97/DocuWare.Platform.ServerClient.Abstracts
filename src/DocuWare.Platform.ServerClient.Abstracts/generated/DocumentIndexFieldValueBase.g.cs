using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentIndexFieldValueBase(SDK.DocumentIndexFieldValueBase obj) : IDocumentIndexFieldValueBase
    {
        internal SDK.DocumentIndexFieldValueBase Obj { get; } = obj;

        public object Item
        {
            get => Obj.Item;
            set => Obj.Item = value;
        }
    }
}

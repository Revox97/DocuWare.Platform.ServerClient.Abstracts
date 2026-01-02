using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentActionInfo(DocuWare.Platform.ServerClient.DocumentActionInfo obj) : IDocumentActionInfo
    {
        internal DocuWare.Platform.ServerClient.DocumentActionInfo Obj { get; } = obj;

        public DocuWare.Platform.ServerClient.DocumentAction DocumentAction
        {
            get => Obj.DocumentAction;
            set => Obj.DocumentAction = value;
        }
    }
}

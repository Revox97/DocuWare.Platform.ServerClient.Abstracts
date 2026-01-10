using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentActionInfo(DocuWare.Platform.ServerClient.DocumentActionInfo obj) : IDocumentActionInfo
    {
        internal DocuWare.Platform.ServerClient.DocumentActionInfo Obj { get; } = obj;

        public IDocumentActionParameters DocumentActionParameters
        {
            get => new DocumentActionParameters(Obj.DocumentActionParameters);
            set => Obj.DocumentActionParameters = ((DocumentActionParameters)value).Obj;
        }

        public DocumentAction DocumentAction
        {
            get => (DocumentAction)Obj.DocumentAction;
            set => Obj.DocumentAction = (DocuWare.Platform.ServerClient.DocumentAction)value;
        }
    }
}

using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentActionInfo(SDK.DocumentActionInfo obj) : IDocumentActionInfo
    {
        internal SDK.DocumentActionInfo Obj { get; } = obj;

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

using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentVersion(SDK.DocumentVersion obj) : IDocumentVersion
    {
        internal SDK.DocumentVersion Obj { get; } = obj;

        public int Major
        {
            get => Obj.Major;
            set => Obj.Major = value;
        }

        public int Minor
        {
            get => Obj.Minor;
            set => Obj.Minor = value;
        }
    }
}

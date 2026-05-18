using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AppendActionDocuments(SDK.AppendActionDocuments obj) : IAppendActionDocuments
    {
        internal SDK.AppendActionDocuments Obj { get; } = obj;

        public string SourceCabinetId
        {
            get => Obj.SourceCabinetId;
            set => Obj.SourceCabinetId = value;
        }

        public List<int> Documents
        {
            get => Obj.Documents;
            set => Obj.Documents = value;
        }
    }
}

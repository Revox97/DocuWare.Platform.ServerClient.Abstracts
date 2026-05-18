using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ContentMergeOperationInfo(SDK.ContentMergeOperationInfo obj) : IContentMergeOperationInfo
    {
        internal SDK.ContentMergeOperationInfo Obj { get; } = obj;

        public List<int> Documents
        {
            get => Obj.Documents;
            set => Obj.Documents = value;
        }

        public ContentMergeOperation Operation
        {
            get => (ContentMergeOperation)Obj.Operation;
            set => Obj.Operation = (DocuWare.Platform.ServerClient.ContentMergeOperation)value;
        }

        public bool Force
        {
            get => Obj.Force;
            set => Obj.Force = value;
        }
    }
}

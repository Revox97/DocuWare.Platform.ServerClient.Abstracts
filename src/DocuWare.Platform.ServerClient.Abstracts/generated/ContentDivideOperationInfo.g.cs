using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ContentDivideOperationInfo(SDK.ContentDivideOperationInfo obj) : IContentDivideOperationInfo
    {
        internal SDK.ContentDivideOperationInfo Obj { get; } = obj;

        public List<int> Pages
        {
            get => Obj.Pages;
            set => Obj.Pages = value;
        }

        public List<string> ResultNames
        {
            get => Obj.ResultNames;
            set => Obj.ResultNames = value;
        }

        public ContentDivideOperation Operation
        {
            get => (ContentDivideOperation)Obj.Operation;
            set => Obj.Operation = (DocuWare.Platform.ServerClient.ContentDivideOperation)value;
        }

        public bool Force
        {
            get => Obj.Force;
            set => Obj.Force = value;
        }
    }
}

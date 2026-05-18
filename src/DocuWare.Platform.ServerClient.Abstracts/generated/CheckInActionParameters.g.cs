using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class CheckInActionParameters(SDK.CheckInActionParameters obj) : ICheckInActionParameters
    {
        internal SDK.CheckInActionParameters Obj { get; } = obj;

        public string MediaType => Obj.MediaType;

        public IDocumentVersion DocumentVersion
        {
            get => new DocumentVersion(Obj.DocumentVersion);
            set => Obj.DocumentVersion = ((DocumentVersion)value).Obj;
        }

        public CheckInReturnDocument CheckInReturnDocument
        {
            get => (CheckInReturnDocument)Obj.CheckInReturnDocument;
            set => Obj.CheckInReturnDocument = (DocuWare.Platform.ServerClient.CheckInReturnDocument)value;
        }

        public string Comments
        {
            get => Obj.Comments;
            set => Obj.Comments = value;
        }
    }
}

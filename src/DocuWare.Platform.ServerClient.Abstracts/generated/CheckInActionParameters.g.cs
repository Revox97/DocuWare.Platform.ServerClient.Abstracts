using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class CheckInActionParameters(SDK.CheckInActionParameters obj) : ICheckInActionParameters
    {
        internal SDK.CheckInActionParameters Obj { get; } = obj;

        public IDocumentVersion DocumentVersion
        {
            get => new DocumentVersion(Obj.DocumentVersion);
            set => Obj.DocumentVersion = ((DocumentVersion)value).Obj;
        }

        public DocuWare.Platform.ServerClient.CheckInReturnDocument CheckInReturnDocument
        {
            get => Obj.CheckInReturnDocument;
            set => Obj.CheckInReturnDocument = value;
        }

        public string Comments
        {
            get => Obj.Comments;
            set => Obj.Comments = value;
        }
    }
}

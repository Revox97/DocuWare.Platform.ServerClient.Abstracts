using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class CheckInActionParameters(DocuWare.Platform.ServerClient.CheckInActionParameters obj) : ICheckInActionParameters
    {
        internal DocuWare.Platform.ServerClient.CheckInActionParameters Obj { get; } = obj;

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

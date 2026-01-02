using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class CheckInActionParameters(DocuWare.Platform.ServerClient.CheckInActionParameters obj) : ICheckInActionParameters
    {
        internal DocuWare.Platform.ServerClient.CheckInActionParameters Obj { get; } = obj;

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

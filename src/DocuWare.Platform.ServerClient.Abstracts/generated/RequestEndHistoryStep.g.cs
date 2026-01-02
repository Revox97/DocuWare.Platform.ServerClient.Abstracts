using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class RequestEndHistoryStep(DocuWare.Platform.ServerClient.RequestEndHistoryStep obj) : IRequestEndHistoryStep
    {
        internal DocuWare.Platform.ServerClient.RequestEndHistoryStep Obj { get; } = obj;

        public string UserName
        {
            get => Obj.UserName;
            set => Obj.UserName = value;
        }

        public bool DocumentDeleted
        {
            get => Obj.DocumentDeleted;
            set => Obj.DocumentDeleted = value;
        }
    }
}

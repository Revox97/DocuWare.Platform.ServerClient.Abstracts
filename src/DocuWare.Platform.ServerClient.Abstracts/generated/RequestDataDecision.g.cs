using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class RequestDataDecision(DocuWare.Platform.ServerClient.RequestDataDecision obj) : IRequestDataDecision
    {
        internal DocuWare.Platform.ServerClient.RequestDataDecision Obj { get; } = obj;

        public string UserName
        {
            get => Obj.UserName;
            set => Obj.UserName = value;
        }

        public string DecisionName
        {
            get => Obj.DecisionName;
            set => Obj.DecisionName = value;
        }

        public string Comment
        {
            get => Obj.Comment;
            set => Obj.Comment = value;
        }
    }
}

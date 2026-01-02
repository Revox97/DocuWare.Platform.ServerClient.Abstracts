using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ReassignHistoryStep(DocuWare.Platform.ServerClient.ReassignHistoryStep obj) : IReassignHistoryStep
    {
        internal DocuWare.Platform.ServerClient.ReassignHistoryStep Obj { get; } = obj;

        public List<string> RecipientsName
        {
            get => Obj.RecipientsName;
            set => Obj.RecipientsName = value;
        }

        public string Subject
        {
            get => Obj.Subject;
            set => Obj.Subject = value;
        }

        public bool SendMail
        {
            get => Obj.SendMail;
            set => Obj.SendMail = value;
        }

        public string UserName
        {
            get => Obj.UserName;
            set => Obj.UserName = value;
        }
    }
}

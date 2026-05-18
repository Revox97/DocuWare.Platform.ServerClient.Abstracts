using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ReassignmentData(SDK.ReassignmentData obj) : IReassignmentData
    {
        internal SDK.ReassignmentData Obj { get; } = obj;

        public List<IAssignedItem> ReassignmentList
        {
            get => Obj.ReassignmentList.Select(x => new AssignedItem(x) as IAssignedItem).ToList();
            set => Obj.ReassignmentList = value.Select(x => ((AssignedItem)x).Obj).ToList();
        }

        public string Subject
        {
            get => Obj.Subject;
            set => Obj.Subject = value;
        }

        public string Body
        {
            get => Obj.Body;
            set => Obj.Body = value;
        }

        public bool SendEmail
        {
            get => Obj.SendEmail;
            set => Obj.SendEmail = value;
        }
    }
}

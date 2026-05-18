using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AssignToHistoryStep(SDK.AssignToHistoryStep obj) : IAssignToHistoryStep
    {
        internal SDK.AssignToHistoryStep Obj { get; } = obj;

        public List<string> AssignedUsers
        {
            get => Obj.AssignedUsers;
            set => Obj.AssignedUsers = value;
        }
    }
}

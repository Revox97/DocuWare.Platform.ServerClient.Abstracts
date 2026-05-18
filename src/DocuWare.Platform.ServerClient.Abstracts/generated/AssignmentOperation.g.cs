using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AssignmentOperation(SDK.AssignmentOperation obj) : IAssignmentOperation
    {
        internal SDK.AssignmentOperation Obj { get; } = obj;

        public List<string> Ids
        {
            get => Obj.Ids;
            set => Obj.Ids = value;
        }

        public AssignmentOperationType OperationType
        {
            get => (AssignmentOperationType)Obj.OperationType;
            set => Obj.OperationType = (DocuWare.Platform.ServerClient.AssignmentOperationType)value;
        }
    }
}

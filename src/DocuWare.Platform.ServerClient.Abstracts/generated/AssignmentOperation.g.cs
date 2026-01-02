using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AssignmentOperation(DocuWare.Platform.ServerClient.AssignmentOperation obj) : IAssignmentOperation
    {
        internal DocuWare.Platform.ServerClient.AssignmentOperation Obj { get; } = obj;

        public List<string> Ids
        {
            get => Obj.Ids;
            set => Obj.Ids = value;
        }

        public DocuWare.Platform.ServerClient.AssignmentOperationType OperationType
        {
            get => Obj.OperationType;
            set => Obj.OperationType = value;
        }
    }
}

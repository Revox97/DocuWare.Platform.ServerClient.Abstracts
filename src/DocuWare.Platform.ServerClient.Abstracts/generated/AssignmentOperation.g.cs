using SDK = DocuWare.Platform.ServerClient;

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
			get => new ssignmentOperationType(Obj.OperationType);
			set => Obj.OperationType = ((ssignmentOperationType)value).Obj;
		}
    }
}

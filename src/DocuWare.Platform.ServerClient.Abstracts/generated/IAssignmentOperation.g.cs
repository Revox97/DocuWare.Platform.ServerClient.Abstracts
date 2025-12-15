using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IAssignmentOperation
    {
		List<string> Ids { get; set; }
		DocuWare.Platform.ServerClient.AssignmentOperationType OperationType { get; set; }
    }
}

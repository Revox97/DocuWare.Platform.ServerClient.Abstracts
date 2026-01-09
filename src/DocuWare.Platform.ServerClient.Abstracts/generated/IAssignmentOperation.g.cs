using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IAssignmentOperation{3}
    {
		List<string> Ids { get; set; }
		AssignmentOperationType OperationType { get; set; }
    }
}

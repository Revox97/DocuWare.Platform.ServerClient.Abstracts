using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITaskTableFieldInitialValues
    {
		IDocumentIndexFieldTable DocumentIndexFieldTable { get; set; }
		DocuWare.Platform.ServerClient.TaskTableFieldJoinTypeEnum TaskTableFieldJoinType { get; set; }
    }
}

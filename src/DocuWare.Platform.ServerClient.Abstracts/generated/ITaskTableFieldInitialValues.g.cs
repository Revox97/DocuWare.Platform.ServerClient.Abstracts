using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITaskTableFieldInitialValues
    {
		IDocumentIndexFieldTable DocumentIndexFieldTable { get; set; }
		TaskTableFieldJoinTypeEnum TaskTableFieldJoinType { get; set; }
    }
}

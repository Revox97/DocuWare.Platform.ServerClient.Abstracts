using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITaskTableFieldInitialValues
    {
		DocuWare.Platform.ServerClient.TaskTableFieldJoinTypeEnum TaskTableFieldJoinType { get; set; }
    }
}

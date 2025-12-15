using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IAssignedItem
    {
		string Id { get; set; }
		DocuWare.Platform.ServerClient.AssignedItemTypeEnum ItemType { get; set; }
    }
}

using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IAssignedItem
    {
		string Id { get; set; }
		AssignedItemTypeEnum ItemType { get; set; }
    }
}

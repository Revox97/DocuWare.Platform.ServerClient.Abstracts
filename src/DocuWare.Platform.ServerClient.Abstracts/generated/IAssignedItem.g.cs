using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IAssignedItem{3}
    {
		string Id { get; set; }
		AssignedItemTypeEnum ItemType { get; set; }
    }
}

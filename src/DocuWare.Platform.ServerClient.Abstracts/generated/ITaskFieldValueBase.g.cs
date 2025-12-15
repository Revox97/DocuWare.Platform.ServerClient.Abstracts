using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITaskFieldValueBase
    {
		object Item { get; set; }
		DocuWare.Platform.ServerClient.ItemChoiceType1 ItemElementName { get; set; }
    }
}

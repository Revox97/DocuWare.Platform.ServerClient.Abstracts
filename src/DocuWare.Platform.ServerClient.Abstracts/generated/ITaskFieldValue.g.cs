using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITaskFieldValue
    {
		object Item { get; set; }
		DocuWare.Platform.ServerClient.ItemChoiceType1 ItemElementName { get; set; }
    }
}

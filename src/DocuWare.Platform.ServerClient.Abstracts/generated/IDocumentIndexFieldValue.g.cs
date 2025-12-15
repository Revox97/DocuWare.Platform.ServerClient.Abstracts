using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentIndexFieldValue
    {
		object Item { get; set; }
		DocuWare.Platform.ServerClient.ItemChoiceType ItemElementName { get; set; }
    }
}

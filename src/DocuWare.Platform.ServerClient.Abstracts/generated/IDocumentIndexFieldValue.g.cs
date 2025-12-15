using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentIndexFieldValue
    {
		Object Item { get; set; }
		ItemChoiceType ItemElementName { get; set; }
    }
}

using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISuggestionValue
    {
		IPointAndShootInfo Source { get; set; }
		object Item { get; set; }
		DocuWare.Platform.ServerClient.ItemChoiceType ItemElementName { get; set; }
    }
}

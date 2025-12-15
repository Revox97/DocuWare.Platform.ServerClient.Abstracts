using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISuggestionValue
    {
		IPointAndShootInfo Source { get; set; }
		Object Item { get; set; }
		ItemChoiceType ItemElementName { get; set; }
    }
}

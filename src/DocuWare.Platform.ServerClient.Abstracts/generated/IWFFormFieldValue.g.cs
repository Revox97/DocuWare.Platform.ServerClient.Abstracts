using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IWFFormFieldValue
    {
		Object Item { get; set; }
		ItemChoiceType ItemElementName { get; set; }
    }
}

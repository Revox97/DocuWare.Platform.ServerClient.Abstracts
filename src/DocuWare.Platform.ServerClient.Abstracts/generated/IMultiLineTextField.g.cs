using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IMultiLineTextField : IWebFormField
    {
		int? MinLength { get; set; }
		int? MaxLength { get; set; }
		PredefinedEntryType PredefinedEntry { get; set; }
		string PredefinedCustomEntry { get; set; }
    }
}

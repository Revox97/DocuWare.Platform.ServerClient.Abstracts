using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDateField : IWebFormField
    {
		string LocalValue { get; set; }
		PredefinedEntryType PredefinedEntry { get; set; }
		string PredefinedCustomEntry { get; set; }
    }
}

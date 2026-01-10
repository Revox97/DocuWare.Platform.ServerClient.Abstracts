using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITextField : IWebFormField
    {
		string FieldMaskErrorText { get; set; }
		string FieldMaskRegularExpression { get; set; }
		string FieldMaskSampleEditText { get; set; }
		int? MinLength { get; set; }
		int? MaxLength { get; set; }
		PredefinedEntryType PredefinedEntry { get; set; }
		string PredefinedCustomEntry { get; set; }
    }
}

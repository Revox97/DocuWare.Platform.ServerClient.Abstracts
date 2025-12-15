using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IMultiLineTextField
    {
		int? MinLength { get; set; }
		bool MinLengthSpecified { get; set; }
		int? MaxLength { get; set; }
		bool MaxLengthSpecified { get; set; }
		DocuWare.Platform.ServerClient.PredefinedEntryType PredefinedEntry { get; set; }
		string PredefinedCustomEntry { get; set; }
		string Value { get; set; }
		string Type { get; set; }
		bool Hidden { get; set; }
		bool Readonly { get; set; }
		bool Required { get; set; }
		string Hint { get; set; }
		string ValidationID { get; set; }
		string ID { get; set; }
		string Label { get; set; }
		IPosition Position { get; set; }
		string BehaviorID { get; set; }
    }
}

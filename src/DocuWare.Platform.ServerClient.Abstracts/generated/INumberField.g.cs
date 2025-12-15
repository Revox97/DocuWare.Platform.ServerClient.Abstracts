using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface INumberField
    {
		bool ForceDecimalPlaces { get; set; }
		int DecimalPlaces { get; set; }
		double? MinValue { get; set; }
		bool MinValueSpecified { get; set; }
		double? MaxValue { get; set; }
		bool MaxValueSpecified { get; set; }
		DocuWare.Platform.ServerClient.PredefinedEntryType PredefinedEntry { get; set; }
		double? PredefinedCustomEntry { get; set; }
		bool PredefinedCustomEntrySpecified { get; set; }
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

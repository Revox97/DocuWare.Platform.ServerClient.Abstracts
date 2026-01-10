using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface INumberField : IWebFormField
    {
		bool ForceDecimalPlaces { get; set; }
		int DecimalPlaces { get; set; }
		double? MinValue { get; set; }
		double? MaxValue { get; set; }
		PredefinedEntryType PredefinedEntry { get; set; }
		double? PredefinedCustomEntry { get; set; }
    }
}

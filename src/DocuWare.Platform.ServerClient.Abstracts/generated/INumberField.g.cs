using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface INumberField : IWebFormField
    {
		double? MinValue { get; set; }
		double? MaxValue { get; set; }
		double? PredefinedCustomEntry { get; set; }
    }
}

using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IRadioGroup : IWebFormField
    {
		List<IWebFormOption> Options { get; set; }
		OrientationType Orientation { get; set; }
		int NumberOfColumns { get; set; }
		ColumnWidthType ColumnWidth { get; set; }
		string SortOrder { get; set; }
		List<List<IWebFormOption>> OptionsRows { get; set; }
		string PredefinedValue { get; set; }
    }
}

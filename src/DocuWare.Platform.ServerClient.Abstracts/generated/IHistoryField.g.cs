using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IHistoryField
    {
		IWFFormFieldValue Value { get; set; }
		IHistoryFieldOptions Options { get; set; }
		AssignmentType AssignmentType { get; set; }
		string Label { get; set; }
		HistoryFormTypeEnum Type { get; set; }
    }
}

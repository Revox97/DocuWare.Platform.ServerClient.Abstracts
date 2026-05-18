using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITableResultHeader
    {
		string FieldName { get; set; }
		string Type { get; set; }
		string FieldLabel { get; set; }
		TableResultFieldKind Kind { get; set; }
		bool IsDocumentName { get; set; }

		ItemChoiceType GetItemChoiceType();
    }
}

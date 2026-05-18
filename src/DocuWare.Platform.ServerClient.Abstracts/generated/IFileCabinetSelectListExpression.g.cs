using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFileCabinetSelectListExpression
    {
		string ValuePrefix { get; set; }
		string FieldName { get; set; }
		int Count { get; set; }
		int Start { get; set; }
		int Limit { get; set; }
		SortDirection SortDirection { get; set; }
		bool Typed { get; set; }
    }
}

using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITaskTableField : IBaseForm
    {
		List<ITaskTableColumn> Columns { get; set; }
		ITaskTableFieldInitialValues InitialValues { get; set; }
		string FieldName { get; set; }
		bool Mandatory { get; set; }
		bool IsReadOnly { get; set; }
    }
}

using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IColumn
    {
		IColumnOptions ColumnOptions { get; set; }
		string Label { get; set; }
		string Id { get; set; }
		ColumnValueTypeEnum ColumnValueType { get; set; }
		ColumnTypeEnum ColumnType { get; set; }
    }
}

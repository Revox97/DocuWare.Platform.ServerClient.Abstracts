using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITableSelectListFilter
    {
		string TableFieldColumnName { get; set; }
		string ColumnName { get; set; }
		int WorkflowFieldId { get; set; }
    }
}

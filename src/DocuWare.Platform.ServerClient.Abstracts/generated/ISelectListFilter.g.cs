using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISelectListFilter
    {
		string ColumnName { get; set; }
		int WorkflowFieldId { get; set; }
    }
}

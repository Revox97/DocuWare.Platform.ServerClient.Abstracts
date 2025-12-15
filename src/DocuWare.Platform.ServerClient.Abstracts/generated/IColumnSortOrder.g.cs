using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IColumnSortOrder
    {
		string ColumnId { get; set; }
		DocuWare.Platform.ServerClient.SortDirection Direction { get; set; }
    }
}

using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IColumnSortOrder{3}
    {
		string ColumnId { get; set; }
		SortDirection Direction { get; set; }
    }
}

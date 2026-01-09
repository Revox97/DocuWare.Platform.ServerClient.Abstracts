using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IColumnsDefinition{3}
    {
		List<IColumn> Column { get; set; }
		List<IColumnSortOrder> Sort { get; set; }
    }
}

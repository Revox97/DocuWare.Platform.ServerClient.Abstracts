using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITableColumnsDefinition
    {
		ITableColumnOptions ColumnOptions { get; set; }
		string Label { get; set; }
		string Id { get; set; }
		DocuWare.Platform.ServerClient.TableColumnValueTypeEnum ColumnValueType { get; set; }
		bool Mandatory { get; set; }
    }
}

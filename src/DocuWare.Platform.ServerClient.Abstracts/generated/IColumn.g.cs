using DocuWare.Platform.ServerClient;

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

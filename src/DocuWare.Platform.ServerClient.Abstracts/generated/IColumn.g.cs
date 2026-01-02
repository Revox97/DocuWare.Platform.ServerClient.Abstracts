using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IColumn
    {
		string Label { get; set; }
		string Id { get; set; }
		DocuWare.Platform.ServerClient.ColumnValueTypeEnum ColumnValueType { get; set; }
		DocuWare.Platform.ServerClient.ColumnTypeEnum ColumnType { get; set; }
    }
}

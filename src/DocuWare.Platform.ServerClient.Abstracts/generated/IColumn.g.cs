using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IColumn{3}
    {
		string Label { get; set; }
		string Id { get; set; }
		ColumnValueTypeEnum ColumnValueType { get; set; }
		ColumnTypeEnum ColumnType { get; set; }
    }
}

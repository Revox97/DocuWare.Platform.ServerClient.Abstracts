using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITableColumnsDefinition{3}
    {
		string Label { get; set; }
		string Id { get; set; }
		TableColumnValueTypeEnum ColumnValueType { get; set; }
		bool Mandatory { get; set; }
    }
}

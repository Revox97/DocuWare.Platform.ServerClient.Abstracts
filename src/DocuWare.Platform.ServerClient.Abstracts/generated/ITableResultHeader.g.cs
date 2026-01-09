using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITableResultHeader{3}
    {
		string FieldName { get; set; }
		string Type { get; set; }
		string FieldLabel { get; set; }
		TableResultFieldKind Kind { get; set; }
		bool IsDocumentName { get; set; }

		string ToString();
		ItemChoiceType GetItemChoiceType();
    }
}

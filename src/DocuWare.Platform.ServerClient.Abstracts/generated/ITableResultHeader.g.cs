using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITableResultHeader
    {
		string FieldName { get; set; }
		string Type { get; set; }
		string FieldLabel { get; set; }
		TableResultFieldKind Kind { get; set; }
		bool IsDocumentName { get; set; }

		ItemChoiceType GetItemChoiceType();
    }
}

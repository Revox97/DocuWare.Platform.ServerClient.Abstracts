using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITableResultHeader
    {
		string FieldName { get; set; }
		string Type { get; set; }
		string FieldLabel { get; set; }
		DocuWare.Platform.ServerClient.TableResultFieldKind Kind { get; set; }
		bool IsDocumentName { get; set; }

		string ToString();
		DocuWare.Platform.ServerClient.ItemChoiceType GetItemChoiceType();
    }
}

using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentIndexField
    {
		IPointAndShootInfo PointAndShootInfo { get; set; }
		string FieldName { get; set; }
		string FieldLabel { get; set; }
		bool IsNull { get; set; }
		bool ReadOnly { get; set; }
		object Item { get; set; }
		DocuWare.Platform.ServerClient.ItemChoiceType ItemElementName { get; set; }

		string ToString();
    }
}

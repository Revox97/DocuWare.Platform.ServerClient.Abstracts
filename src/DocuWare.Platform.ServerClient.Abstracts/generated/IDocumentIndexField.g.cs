using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentIndexField: IDocumentIndexFieldValueBase
    {
		string FieldName { get; set; }
		string FieldLabel { get; set; }
		bool IsNull { get; set; }
		bool ReadOnly { get; set; }
		object Item { get; set; }

		string ToString();
    }
}

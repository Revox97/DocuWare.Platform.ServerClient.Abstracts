using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFormFieldValue
    {
		IDocumentIndexFieldValue TypedValue { get; set; }
		string Name { get; set; }
		string Value { get; set; }
    }
}

using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDecisionFormFieldValue
    {
		int Id { get; set; }
		IDocumentIndexFieldValue TypedValue { get; set; }
		string Name { get; set; }
		string Value { get; set; }
    }
}

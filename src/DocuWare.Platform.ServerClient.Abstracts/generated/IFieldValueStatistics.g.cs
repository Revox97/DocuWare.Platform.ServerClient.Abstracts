using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFieldValueStatistics
    {
		IDocumentIndexFieldValue Value { get; set; }
		long Count { get; set; }
    }
}

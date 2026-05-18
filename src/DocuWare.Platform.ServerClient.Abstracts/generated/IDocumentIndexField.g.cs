using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentIndexField : IDocumentIndexFieldValueBase
    {
		IPointAndShootInfo PointAndShootInfo { get; set; }
		string FieldName { get; set; }
		string FieldLabel { get; set; }
		bool IsNull { get; set; }
		bool ReadOnly { get; set; }
    }
}

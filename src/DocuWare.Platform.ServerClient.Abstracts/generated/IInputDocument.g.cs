using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IInputDocument
    {
		string MediaType { get; }
		List<IDocumentIndexField> Fields { get; set; }
		IInputFlags Flags { get; set; }
		Link[] Links { get; set; }
		List<IInputSection> Sections { get; set; }
		IUploadedFileChunk FileChunk { get; set; }

		void SetProxy(HttpClientProxy proxy);
		IDocument GetDocumentFromSelfRelation();
		Task<DeserializedHttpResponse<IDocument>> GetDocumentFromSelfRelationAsync();
		Task<DeserializedHttpResponse<IDocument>> GetDocumentFromSelfRelationAsync(CancellationToken cancellationToken);
    }
}

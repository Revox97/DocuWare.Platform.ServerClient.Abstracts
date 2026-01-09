using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IInputDocument{3}
    {
		List<IDocumentIndexField> Fields { get; set; }
		Link[] Links { get; set; }
		List<IInputSection> Sections { get; set; }

		void SetProxy(HttpClientProxy proxy);
		IDocument GetDocumentFromSelfRelation();
		Task<DeserializedHttpResponse<IDocument>> GetDocumentFromSelfRelationAsync();
		Task<DeserializedHttpResponse<IDocument>> GetDocumentFromSelfRelationAsync(CancellationToken cancellationToken);
    }
}

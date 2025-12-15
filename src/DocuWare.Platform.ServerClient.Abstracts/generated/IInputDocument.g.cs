using DocuWare.Platform.ServerClient;

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
		string SelfRelationLink { get; }

		void SetProxy(HttpClientProxy proxy);
		IDocument GetDocumentFromSelfRelation();
		Task<DeserializedHttpResponse<IDocument>> GetDocumentFromSelfRelationAsync();
		Task<DeserializedHttpResponse<IDocument>> GetDocumentFromSelfRelationAsync(CancellationToken cancellationToken);
    }
}

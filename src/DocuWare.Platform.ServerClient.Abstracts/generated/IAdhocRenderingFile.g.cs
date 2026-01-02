using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IAdhocRenderingFile
    {
		List<IKeyValuePair> MetaData { get; set; }
		Link[] Links { get; set; }
		string Id { get; set; }
		int PageCount { get; set; }

		void SetProxy(HttpClientProxy proxy);
		IAdhocRenderingFile GetAdhocRenderingFileFromSelfRelation();
		Task<DeserializedHttpResponse<IAdhocRenderingFile>> GetAdhocRenderingFileFromSelfRelationAsync();
		Task<DeserializedHttpResponse<IAdhocRenderingFile>> GetAdhocRenderingFileFromSelfRelationAsync(CancellationToken cancellationToken);
		Stream PostToRenderingRelationForStream(IAdhocRenderingQuery dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToRenderingRelationForStreamAsync(IAdhocRenderingQuery dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToRenderingRelationForStreamAsync(CancellationToken cancellationToken, IAdhocRenderingQuery dataToSend);
    }
}

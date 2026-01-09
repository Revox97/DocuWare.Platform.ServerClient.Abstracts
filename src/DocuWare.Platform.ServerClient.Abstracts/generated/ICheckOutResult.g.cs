using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ICheckOutResult{3}
    {
		Link[] Links { get; set; }
		string ContentRelationLink { get; }

		void SetProxy(HttpClientProxy proxy);
		Stream GetStreamFromContentRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromContentRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromContentRelationAsync(CancellationToken cancellationToken);
    }
}

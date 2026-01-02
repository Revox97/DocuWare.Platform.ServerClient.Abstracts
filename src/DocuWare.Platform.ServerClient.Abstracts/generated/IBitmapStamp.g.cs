using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IBitmapStamp
    {
		Link[] Links { get; set; }

		void SetProxy(HttpClientProxy proxy);
		Stream GetStreamFromContentRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromContentRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromContentRelationAsync(CancellationToken cancellationToken);
    }
}

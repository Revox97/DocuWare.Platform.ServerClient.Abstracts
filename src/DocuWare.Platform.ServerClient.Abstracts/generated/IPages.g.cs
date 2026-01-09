using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IPages
    {
		List<IPage> Page { get; set; }
		Link[] Links { get; set; }

		void SetProxy(HttpClientProxy proxy);
		IPages GetPagesFromNextBlockRelation();
		Task<DeserializedHttpResponse<IPages>> GetPagesFromNextBlockRelationAsync();
		Task<DeserializedHttpResponse<IPages>> GetPagesFromNextBlockRelationAsync(CancellationToken cancellationToken);
    }
}

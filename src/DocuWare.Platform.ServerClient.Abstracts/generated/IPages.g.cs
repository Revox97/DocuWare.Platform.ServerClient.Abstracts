using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

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

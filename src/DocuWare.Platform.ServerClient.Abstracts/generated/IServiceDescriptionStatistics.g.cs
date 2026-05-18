using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IServiceDescriptionStatistics
    {
		Link[] Links { get; set; }

		void SetProxy(HttpClientProxy proxy);
		Stream PostToCfsRelationForStream(ICFSStatisticGeneral dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToCfsRelationForStreamAsync(ICFSStatisticGeneral dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToCfsRelationForStreamAsync(CancellationToken cancellationToken, ICFSStatisticGeneral dataToSend);
    }
}

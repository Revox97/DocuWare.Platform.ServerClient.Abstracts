using DocuWare.Platform.ServerClient;

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

using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IExtendedUserOperations
    {
		Link[] Links { get; set; }

		void SetProxy(HttpClientProxy proxy);
		string PutToReadStatusRelationForString(Stream dataToSend);
		Task<DeserializedHttpResponse<string>> PutToReadStatusRelationForStringAsync(Stream dataToSend);
		Task<DeserializedHttpResponse<string>> PutToReadStatusRelationForStringAsync(CancellationToken cancellationToken, Stream dataToSend);
    }
}

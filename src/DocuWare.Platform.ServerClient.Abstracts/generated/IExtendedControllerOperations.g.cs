using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IExtendedControllerOperations
    {
		Link[] Links { get; set; }
		string InstanceRelationLink { get; }

		void SetProxy(HttpClientProxy proxy);
		string DeleteInstanceRelation();
		Task<DeserializedHttpResponse<string>> DeleteInstanceRelationAsync();
		Task<DeserializedHttpResponse<string>> DeleteInstanceRelationAsync(CancellationToken cancellationToken);
		Stream GetStreamFromInstanceRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromInstanceRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromInstanceRelationAsync(CancellationToken cancellationToken);
    }
}

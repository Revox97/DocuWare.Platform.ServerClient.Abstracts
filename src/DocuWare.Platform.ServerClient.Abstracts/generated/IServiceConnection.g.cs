using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IServiceConnection
    {

		void ReplaceHttpClient(IServiceConnection otherServiceConnection);
		void ReplaceHttpClient(HttpClient httpClient);
		void Disconnect();
		Task DisconnectAsync();
		Task DisconnectAsync(CancellationToken token);
		Task<IOrganization[]> GetOrganizationsAsync();
		IT GetXml(string uri);
		Task<DeserializedHttpResponse<IT>> GetXmlAsync(string uri);
    }
}

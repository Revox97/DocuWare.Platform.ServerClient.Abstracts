using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IServiceConnection
    {
		HttpClient HttpClient { get; }
		HttpClientProxy Proxy { get; }
		IServiceDescription ServiceDescription { get; }
		IOrganization[] Organizations { get; }
		Task<IOrganization[]> OrganizationsAsync { get; }

		void ReplaceHttpClient(IServiceConnection otherServiceConnection);
		void ReplaceHttpClient(HttpClient httpClient);
		void Disconnect();
		Task DisconnectAsync();
		Task DisconnectAsync(CancellationToken token);
		Task<IOrganization[]> GetOrganizationsAsync();
		T GetXml(string uri);
		Task<DeserializedHttpResponse<T>> GetXmlAsync(string uri);
    }
}

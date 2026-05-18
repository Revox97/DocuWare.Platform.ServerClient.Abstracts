using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

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
    }
}

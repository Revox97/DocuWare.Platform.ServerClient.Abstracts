using System.Net;
using System.Net.Http.Headers;
using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocuWare
    {
		Task<IServiceConnection> CreateAsync(Uri serviceUri, string userName, string password, string organization, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpMessageHandler httpClientHandler, ProductInfoHeaderValue[] userAgent);
		Task<IServiceConnection> CreateAsync(Uri serviceUri, string userName, string password, IServiceConnectionLoginData serviceConnectionData);
		Task<IServiceConnection> CreateTrustedAsync(Uri serviceUri, string impersonatedUser, string trustedUser, string password, string organization, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpMessageHandler httpClientHandler, ProductInfoHeaderValue[] userAgent);
		Task<IServiceConnection> CreateTrustedAsync(Uri serviceUri, string impersonatedUser, string trustedUser, string password, IServiceConnectionLoginData serviceConnectionData);
		Task<IServiceConnection> CreateAsync(Uri serviceUri, string token, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpMessageHandler httpClientHandler, ProductInfoHeaderValue[] userAgent);
		Task<IServiceConnection> CreateAsync(Uri serviceUri, string token, IServiceConnectionTokenLoginData serviceConnectionTokenLoginData);
		Task<IIdentityServiceInfo> GetIdentityServiceInfoAsync(Uri serviceUri, IIdentityServiceInfoConnectionData serviceConnectionData);
		Task<IServiceConnection> CreateWithJwtAsync(Uri serviceUri, string accessToken, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpMessageHandler httpClientHandler, ProductInfoHeaderValue[] userAgent);
		Task<IServiceConnection> CreateWithJwtAsync(Uri serviceUri, string accessToken, IServiceConnectionTokenLoginData serviceConnectionTokenLoginData);
		Task<IServiceConnection> CreateWithJwtAsync(Uri serviceUri, string accessToken, Func<Task<string>> refreshTokenCallback, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpMessageHandler httpClientHandler, ProductInfoHeaderValue[] userAgent);
		Task<IServiceConnection> CreateWithJwtAsync(Uri serviceUri, string accessToken, IServiceConnectionTokenLoginData serviceConnectionTokenLoginData, Func<Task<string>> refreshTokenCallback);
		Task<IServiceConnection> CreateAsync(Uri serviceUri, HttpMessageHandler httpClientHandler, ProductInfoHeaderValue[] userAgent);
		Task<IServiceConnection> CreateAsync(Uri serviceUri, IServiceConnectionTransportData serviceConnectionTransportData);
		Task<IServiceConnection> CreateWithWindowsAuthenticationAsync(Uri serviceUri, ICredentials credentials, string organization, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpClientHandler httpClientHandler, ProductInfoHeaderValue[] userAgent);
		Task<IServiceConnection> CreateWithWindowsAuthenticationAsync(Uri serviceUri, ICredentials credentials, IServiceConnectionLoginData serviceConnectionLoginData);
		Task<IServiceConnection> CreateWithWindowsAuthenticationAsync(Uri serviceUri, string userName, string password, string domain, string organization, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpClientHandler httpClientHandler, ProductInfoHeaderValue[] userAgent);
		Task<IServiceConnection> CreateWithWindowsAuthenticationAsync(Uri serviceUri, string userName, string password, string domain, IServiceConnectionLoginData serviceConnectionLoginData);
		Task<IServiceConnection> CreateWithWindowsAuthenticationAsync(Uri serviceUri, string userName, string password, IServiceConnectionLoginData serviceConnectionLoginData);
		IServiceConnection Create(Uri serviceUri, string userName, string password, string organization, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpMessageHandler httpClientHandler, ProductInfoHeaderValue[] userAgent);
		IServiceConnection CreateTrusted(Uri serviceUri, string impersonatedUser, string trustedUser, string password, string organization, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpMessageHandler httpClientHandler, ProductInfoHeaderValue[] userAgent);
		IServiceConnection Create(Uri serviceUri, string token, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpMessageHandler httpClientHandler, ProductInfoHeaderValue[] userAgent);
		IServiceConnection Create(Uri serviceUri, HttpMessageHandler httpClientHandler, ProductInfoHeaderValue[] userAgent);
		IServiceConnection CreateWithWindowsAuthentication(Uri serviceUri, ICredentials credentials, string organization, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpClientHandler httpClientHandler, ProductInfoHeaderValue[] userAgent);
		IServiceConnection CreateWithWindowsAuthentication(Uri serviceUri, string userName, string password, string domain, string organization, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpClientHandler httpClientHandler, ProductInfoHeaderValue[] userAgent);
		void SetHostId(string hostId);
    }
}

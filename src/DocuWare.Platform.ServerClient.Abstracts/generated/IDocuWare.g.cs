using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocuWare
    {
		Task<T> CreateAsync(Uri serviceUri, string userName, string password, string organization, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpMessageHandler httpClientHandler, ProductInfoHeaderValue[] userAgent);
		Task<T> CreateAsync(Uri serviceUri, string userName, string password, IServiceConnectionLoginData serviceConnectionData);
		Task<T> CreateTrustedAsync(Uri serviceUri, string impersonatedUser, string trustedUser, string password, string organization, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpMessageHandler httpClientHandler, ProductInfoHeaderValue[] userAgent);
		Task<T> CreateTrustedAsync(Uri serviceUri, string impersonatedUser, string trustedUser, string password, IServiceConnectionLoginData serviceConnectionData);
		Task<T> CreateAsync(Uri serviceUri, string token, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpMessageHandler httpClientHandler, ProductInfoHeaderValue[] userAgent);
		Task<T> CreateAsync(Uri serviceUri, string token, IServiceConnectionTokenLoginData serviceConnectionTokenLoginData);
		Task<T> GetIdentityServiceInfoAsync(Uri serviceUri, IIdentityServiceInfoConnectionData serviceConnectionData);
		Task<T> CreateWithJwtAsync(Uri serviceUri, string accessToken, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpMessageHandler httpClientHandler, ProductInfoHeaderValue[] userAgent);
		Task<T> CreateWithJwtAsync(Uri serviceUri, string accessToken, IServiceConnectionTokenLoginData serviceConnectionTokenLoginData);
		Task<T> CreateWithJwtAsync(Uri serviceUri, string accessToken, Func<Task<string>> refreshTokenCallback, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpMessageHandler httpClientHandler, ProductInfoHeaderValue[] userAgent);
		Task<T> CreateWithJwtAsync(Uri serviceUri, string accessToken, IServiceConnectionTokenLoginData serviceConnectionTokenLoginData, Func<Task<string>> refreshTokenCallback);
		Task<T> CreateAsync(Uri serviceUri, HttpMessageHandler httpClientHandler, ProductInfoHeaderValue[] userAgent);
		Task<T> CreateAsync(Uri serviceUri, IServiceConnectionTransportData serviceConnectionTransportData);
		Task<T> CreateWithWindowsAuthenticationAsync(Uri serviceUri, ICredentials credentials, string organization, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpClientHandler httpClientHandler, ProductInfoHeaderValue[] userAgent);
		Task<T> CreateWithWindowsAuthenticationAsync(Uri serviceUri, ICredentials credentials, IServiceConnectionLoginData serviceConnectionLoginData);
		Task<T> CreateWithWindowsAuthenticationAsync(Uri serviceUri, string userName, string password, string domain, string organization, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpClientHandler httpClientHandler, ProductInfoHeaderValue[] userAgent);
		Task<T> CreateWithWindowsAuthenticationAsync(Uri serviceUri, string userName, string password, string domain, IServiceConnectionLoginData serviceConnectionLoginData);
		Task<T> CreateWithWindowsAuthenticationAsync(Uri serviceUri, string userName, string password, IServiceConnectionLoginData serviceConnectionLoginData);
		ServiceConnection Create(Uri serviceUri, string userName, string password, string organization, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpMessageHandler httpClientHandler, ProductInfoHeaderValue[] userAgent);
		ServiceConnection CreateTrusted(Uri serviceUri, string impersonatedUser, string trustedUser, string password, string organization, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpMessageHandler httpClientHandler, ProductInfoHeaderValue[] userAgent);
		ServiceConnection Create(Uri serviceUri, string token, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpMessageHandler httpClientHandler, ProductInfoHeaderValue[] userAgent);
		ServiceConnection Create(Uri serviceUri, HttpMessageHandler httpClientHandler, ProductInfoHeaderValue[] userAgent);
		ServiceConnection CreateWithWindowsAuthentication(Uri serviceUri, ICredentials credentials, string organization, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpClientHandler httpClientHandler, ProductInfoHeaderValue[] userAgent);
		ServiceConnection CreateWithWindowsAuthentication(Uri serviceUri, string userName, string password, string domain, string organization, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpClientHandler httpClientHandler, ProductInfoHeaderValue[] userAgent);
		void SetHostId(string hostId);
    }
}

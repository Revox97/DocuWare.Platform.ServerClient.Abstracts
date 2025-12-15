using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class RealDocuWare()
    {

		public async Task<IServiceConnection> CreateAsync(Uri serviceUri, string userName, string password, string? organization = null, DocuWare.Platform.ServerClient.DWProductTypes? licenseType = null, HttpMessageHandler? httpClientHandler = null, ProductInfoHeaderValue[]? userAgent = null)
		{
			return SDK.ServiceConnection.CreateAsync(serviceUri, userName, password, organization, licenseType, httpClientHandler, userAgent);
		}

		public async Task<IServiceConnection> CreateAsync(Uri serviceUri, string userName, string password, IServiceConnectionLoginData serviceConnectionData)
		{
			return SDK.ServiceConnection.CreateAsync(serviceUri, userName, password, serviceConnectionData);
		}

		public async Task<IServiceConnection> CreateTrustedAsync(Uri serviceUri, string impersonatedUser, string trustedUser, string password, string? organization = null, DocuWare.Platform.ServerClient.DWProductTypes? licenseType = null, HttpMessageHandler? httpClientHandler = null, ProductInfoHeaderValue[]? userAgent = null)
		{
			return SDK.ServiceConnection.CreateTrustedAsync(serviceUri, impersonatedUser, trustedUser, password, organization, licenseType, httpClientHandler, userAgent);
		}

		public async Task<IServiceConnection> CreateTrustedAsync(Uri serviceUri, string impersonatedUser, string trustedUser, string password, IServiceConnectionLoginData serviceConnectionData)
		{
			return SDK.ServiceConnection.CreateTrustedAsync(serviceUri, impersonatedUser, trustedUser, password, serviceConnectionData);
		}

		public async Task<IServiceConnection> CreateAsync(Uri serviceUri, string token, DocuWare.Platform.ServerClient.DWProductTypes? licenseType = null, HttpMessageHandler? httpClientHandler = null, ProductInfoHeaderValue[]? userAgent = null)
		{
			return SDK.ServiceConnection.CreateAsync(serviceUri, token, licenseType, httpClientHandler, userAgent);
		}

		public async Task<IServiceConnection> CreateAsync(Uri serviceUri, string token, IServiceConnectionTokenLoginData serviceConnectionTokenLoginData)
		{
			return SDK.ServiceConnection.CreateAsync(serviceUri, token, serviceConnectionTokenLoginData);
		}

		public async Task<IIdentityServiceInfo> GetIdentityServiceInfoAsync(Uri serviceUri, IIdentityServiceInfoConnectionData serviceConnectionData)
		{
			return SDK.ServiceConnection.GetIdentityServiceInfoAsync(serviceUri, serviceConnectionData);
		}

		public async Task<IServiceConnection> CreateWithJwtAsync(Uri serviceUri, string accessToken, DocuWare.Platform.ServerClient.DWProductTypes? licenseType = null, HttpMessageHandler? httpClientHandler = null, ProductInfoHeaderValue[]? userAgent = null)
		{
			return SDK.ServiceConnection.CreateWithJwtAsync(serviceUri, accessToken, licenseType, httpClientHandler, userAgent);
		}

		public async Task<IServiceConnection> CreateWithJwtAsync(Uri serviceUri, string accessToken, IServiceConnectionTokenLoginData serviceConnectionTokenLoginData)
		{
			return SDK.ServiceConnection.CreateWithJwtAsync(serviceUri, accessToken, serviceConnectionTokenLoginData);
		}

		public async Task<IServiceConnection> CreateWithJwtAsync(Uri serviceUri, string accessToken, Func<Task<string>> refreshTokenCallback, DocuWare.Platform.ServerClient.DWProductTypes? licenseType = null, HttpMessageHandler? httpClientHandler = null, ProductInfoHeaderValue[]? userAgent = null)
		{
			return SDK.ServiceConnection.CreateWithJwtAsync(serviceUri, accessToken, refreshTokenCallback, licenseType, httpClientHandler, userAgent);
		}

		public async Task<IServiceConnection> CreateWithJwtAsync(Uri serviceUri, string accessToken, IServiceConnectionTokenLoginData serviceConnectionTokenLoginData, Func<Task<string>> refreshTokenCallback)
		{
			return SDK.ServiceConnection.CreateWithJwtAsync(serviceUri, accessToken, serviceConnectionTokenLoginData, refreshTokenCallback);
		}

		public async Task<IServiceConnection> CreateAsync(Uri serviceUri, HttpMessageHandler? httpClientHandler = null, ProductInfoHeaderValue[]? userAgent = null)
		{
			return SDK.ServiceConnection.CreateAsync(serviceUri, httpClientHandler, userAgent);
		}

		public async Task<IServiceConnection> CreateAsync(Uri serviceUri, IServiceConnectionTransportData serviceConnectionTransportData)
		{
			return SDK.ServiceConnection.CreateAsync(serviceUri, serviceConnectionTransportData);
		}

		public async Task<IServiceConnection> CreateWithWindowsAuthenticationAsync(Uri serviceUri, ICredentials credentials, string? organization = null, DocuWare.Platform.ServerClient.DWProductTypes? licenseType = null, HttpClientHandler? httpClientHandler = null, ProductInfoHeaderValue[]? userAgent = null)
		{
			return SDK.ServiceConnection.CreateWithWindowsAuthenticationAsync(serviceUri, credentials, organization, licenseType, httpClientHandler, userAgent);
		}

		public async Task<IServiceConnection> CreateWithWindowsAuthenticationAsync(Uri serviceUri, ICredentials credentials, IServiceConnectionLoginData serviceConnectionLoginData)
		{
			return SDK.ServiceConnection.CreateWithWindowsAuthenticationAsync(serviceUri, credentials, serviceConnectionLoginData);
		}

		public async Task<IServiceConnection> CreateWithWindowsAuthenticationAsync(Uri serviceUri, string userName, string password, string? domain = null, string? organization = null, DocuWare.Platform.ServerClient.DWProductTypes? licenseType = null, HttpClientHandler? httpClientHandler = null, ProductInfoHeaderValue[]? userAgent = null)
		{
			return SDK.ServiceConnection.CreateWithWindowsAuthenticationAsync(serviceUri, userName, password, domain, organization, licenseType, httpClientHandler, userAgent);
		}

		public async Task<IServiceConnection> CreateWithWindowsAuthenticationAsync(Uri serviceUri, string userName, string password, string domain, IServiceConnectionLoginData serviceConnectionLoginData)
		{
			return SDK.ServiceConnection.CreateWithWindowsAuthenticationAsync(serviceUri, userName, password, domain, serviceConnectionLoginData);
		}

		public async Task<IServiceConnection> CreateWithWindowsAuthenticationAsync(Uri serviceUri, string userName, string password, IServiceConnectionLoginData serviceConnectionLoginData)
		{
			return SDK.ServiceConnection.CreateWithWindowsAuthenticationAsync(serviceUri, userName, password, serviceConnectionLoginData);
		}

		public IServiceConnection Create(Uri serviceUri, string userName, string password, string? organization = null, DocuWare.Platform.ServerClient.DWProductTypes? licenseType = null, HttpMessageHandler? httpClientHandler = null, ProductInfoHeaderValue[]? userAgent = null)
		{
			return SDK.ServiceConnection.Create(serviceUri, userName, password, organization, licenseType, httpClientHandler, userAgent);
		}

		public IServiceConnection CreateTrusted(Uri serviceUri, string impersonatedUser, string trustedUser, string password, string? organization = null, DocuWare.Platform.ServerClient.DWProductTypes? licenseType = null, HttpMessageHandler? httpClientHandler = null, ProductInfoHeaderValue[]? userAgent = null)
		{
			return SDK.ServiceConnection.CreateTrusted(serviceUri, impersonatedUser, trustedUser, password, organization, licenseType, httpClientHandler, userAgent);
		}

		public IServiceConnection Create(Uri serviceUri, string token, DocuWare.Platform.ServerClient.DWProductTypes? licenseType = null, HttpMessageHandler? httpClientHandler = null, ProductInfoHeaderValue[]? userAgent = null)
		{
			return SDK.ServiceConnection.Create(serviceUri, token, licenseType, httpClientHandler, userAgent);
		}

		public IServiceConnection Create(Uri serviceUri, HttpMessageHandler? httpClientHandler = null, ProductInfoHeaderValue[]? userAgent = null)
		{
			return SDK.ServiceConnection.Create(serviceUri, httpClientHandler, userAgent);
		}

		public IServiceConnection CreateWithWindowsAuthentication(Uri serviceUri, ICredentials credentials, string? organization = null, DocuWare.Platform.ServerClient.DWProductTypes? licenseType = null, HttpClientHandler? httpClientHandler = null, ProductInfoHeaderValue[]? userAgent = null)
		{
			return SDK.ServiceConnection.CreateWithWindowsAuthentication(serviceUri, credentials, organization, licenseType, httpClientHandler, userAgent);
		}

		public IServiceConnection CreateWithWindowsAuthentication(Uri serviceUri, string userName, string password, string? domain = null, string? organization = null, DocuWare.Platform.ServerClient.DWProductTypes? licenseType = null, HttpClientHandler? httpClientHandler = null, ProductInfoHeaderValue[]? userAgent = null)
		{
			return SDK.ServiceConnection.CreateWithWindowsAuthentication(serviceUri, userName, password, domain, organization, licenseType, httpClientHandler, userAgent);
		}

		public void SetHostId(string hostId)
		{
			return SDK.ServiceConnection.SetHostId(hostId);
		}
    }
}


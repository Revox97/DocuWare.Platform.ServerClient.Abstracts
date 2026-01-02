using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class RealDocuWare()
    {

		public async Task<T> CreateAsync(Uri serviceUri, string userName, string password, string organization, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpMessageHandler httpClientHandler, ProductInfoHeaderValue[] userAgent)
		{
			return SDK.ServiceConnection.CreateAsync(serviceUri, userName, password, organization, licenseType, httpClientHandler, userAgent);
		}

		public async Task<T> CreateAsync(Uri serviceUri, string userName, string password, IServiceConnectionLoginData serviceConnectionData)
		{
			return SDK.ServiceConnection.CreateAsync(serviceUri, userName, password, ((ServiceConnectionLoginData)serviceConnectionData).Obj);
		}

		public async Task<T> CreateTrustedAsync(Uri serviceUri, string impersonatedUser, string trustedUser, string password, string organization, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpMessageHandler httpClientHandler, ProductInfoHeaderValue[] userAgent)
		{
			return SDK.ServiceConnection.CreateTrustedAsync(serviceUri, impersonatedUser, trustedUser, password, organization, licenseType, httpClientHandler, userAgent);
		}

		public async Task<T> CreateTrustedAsync(Uri serviceUri, string impersonatedUser, string trustedUser, string password, IServiceConnectionLoginData serviceConnectionData)
		{
			return SDK.ServiceConnection.CreateTrustedAsync(serviceUri, impersonatedUser, trustedUser, password, ((ServiceConnectionLoginData)serviceConnectionData).Obj);
		}

		public async Task<T> CreateAsync(Uri serviceUri, string token, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpMessageHandler httpClientHandler, ProductInfoHeaderValue[] userAgent)
		{
			return SDK.ServiceConnection.CreateAsync(serviceUri, token, licenseType, httpClientHandler, userAgent);
		}

		public async Task<T> CreateAsync(Uri serviceUri, string token, IServiceConnectionTokenLoginData serviceConnectionTokenLoginData)
		{
			return SDK.ServiceConnection.CreateAsync(serviceUri, token, ((ServiceConnectionTokenLoginData)serviceConnectionTokenLoginData).Obj);
		}

		public async Task<T> GetIdentityServiceInfoAsync(Uri serviceUri, IIdentityServiceInfoConnectionData serviceConnectionData)
		{
			return SDK.ServiceConnection.GetIdentityServiceInfoAsync(serviceUri, ((IdentityServiceInfoConnectionData)serviceConnectionData).Obj);
		}

		public async Task<T> CreateWithJwtAsync(Uri serviceUri, string accessToken, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpMessageHandler httpClientHandler, ProductInfoHeaderValue[] userAgent)
		{
			return SDK.ServiceConnection.CreateWithJwtAsync(serviceUri, accessToken, licenseType, httpClientHandler, userAgent);
		}

		public async Task<T> CreateWithJwtAsync(Uri serviceUri, string accessToken, IServiceConnectionTokenLoginData serviceConnectionTokenLoginData)
		{
			return SDK.ServiceConnection.CreateWithJwtAsync(serviceUri, accessToken, ((ServiceConnectionTokenLoginData)serviceConnectionTokenLoginData).Obj);
		}

		public async Task<T> CreateWithJwtAsync(Uri serviceUri, string accessToken, Func<Task<string>> refreshTokenCallback, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpMessageHandler httpClientHandler, ProductInfoHeaderValue[] userAgent)
		{
			return SDK.ServiceConnection.CreateWithJwtAsync(serviceUri, accessToken, refreshTokenCallback, licenseType, httpClientHandler, userAgent);
		}

		public async Task<T> CreateWithJwtAsync(Uri serviceUri, string accessToken, IServiceConnectionTokenLoginData serviceConnectionTokenLoginData, Func<Task<string>> refreshTokenCallback)
		{
			return SDK.ServiceConnection.CreateWithJwtAsync(serviceUri, accessToken, ((ServiceConnectionTokenLoginData)serviceConnectionTokenLoginData).Obj, refreshTokenCallback);
		}

		public async Task<T> CreateAsync(Uri serviceUri, HttpMessageHandler httpClientHandler, ProductInfoHeaderValue[] userAgent)
		{
			return SDK.ServiceConnection.CreateAsync(serviceUri, httpClientHandler, userAgent);
		}

		public async Task<T> CreateAsync(Uri serviceUri, IServiceConnectionTransportData serviceConnectionTransportData)
		{
			return SDK.ServiceConnection.CreateAsync(serviceUri, ((ServiceConnectionTransportData)serviceConnectionTransportData).Obj);
		}

		public async Task<T> CreateWithWindowsAuthenticationAsync(Uri serviceUri, ICredentials credentials, string organization, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpClientHandler httpClientHandler, ProductInfoHeaderValue[] userAgent)
		{
			return SDK.ServiceConnection.CreateWithWindowsAuthenticationAsync(serviceUri, credentials, organization, licenseType, httpClientHandler, userAgent);
		}

		public async Task<T> CreateWithWindowsAuthenticationAsync(Uri serviceUri, ICredentials credentials, IServiceConnectionLoginData serviceConnectionLoginData)
		{
			return SDK.ServiceConnection.CreateWithWindowsAuthenticationAsync(serviceUri, credentials, ((ServiceConnectionLoginData)serviceConnectionLoginData).Obj);
		}

		public async Task<T> CreateWithWindowsAuthenticationAsync(Uri serviceUri, string userName, string password, string domain, string organization, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpClientHandler httpClientHandler, ProductInfoHeaderValue[] userAgent)
		{
			return SDK.ServiceConnection.CreateWithWindowsAuthenticationAsync(serviceUri, userName, password, domain, organization, licenseType, httpClientHandler, userAgent);
		}

		public async Task<T> CreateWithWindowsAuthenticationAsync(Uri serviceUri, string userName, string password, string domain, IServiceConnectionLoginData serviceConnectionLoginData)
		{
			return SDK.ServiceConnection.CreateWithWindowsAuthenticationAsync(serviceUri, userName, password, domain, ((ServiceConnectionLoginData)serviceConnectionLoginData).Obj);
		}

		public async Task<T> CreateWithWindowsAuthenticationAsync(Uri serviceUri, string userName, string password, IServiceConnectionLoginData serviceConnectionLoginData)
		{
			return SDK.ServiceConnection.CreateWithWindowsAuthenticationAsync(serviceUri, userName, password, ((ServiceConnectionLoginData)serviceConnectionLoginData).Obj);
		}

		public ServiceConnection Create(Uri serviceUri, string userName, string password, string organization, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpMessageHandler httpClientHandler, ProductInfoHeaderValue[] userAgent)
		{
			return SDK.ServiceConnection.Create(serviceUri, userName, password, organization, licenseType, httpClientHandler, userAgent);
		}

		public ServiceConnection CreateTrusted(Uri serviceUri, string impersonatedUser, string trustedUser, string password, string organization, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpMessageHandler httpClientHandler, ProductInfoHeaderValue[] userAgent)
		{
			return SDK.ServiceConnection.CreateTrusted(serviceUri, impersonatedUser, trustedUser, password, organization, licenseType, httpClientHandler, userAgent);
		}

		public ServiceConnection Create(Uri serviceUri, string token, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpMessageHandler httpClientHandler, ProductInfoHeaderValue[] userAgent)
		{
			return SDK.ServiceConnection.Create(serviceUri, token, licenseType, httpClientHandler, userAgent);
		}

		public ServiceConnection Create(Uri serviceUri, HttpMessageHandler httpClientHandler, ProductInfoHeaderValue[] userAgent)
		{
			return SDK.ServiceConnection.Create(serviceUri, httpClientHandler, userAgent);
		}

		public ServiceConnection CreateWithWindowsAuthentication(Uri serviceUri, ICredentials credentials, string organization, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpClientHandler httpClientHandler, ProductInfoHeaderValue[] userAgent)
		{
			return SDK.ServiceConnection.CreateWithWindowsAuthentication(serviceUri, credentials, organization, licenseType, httpClientHandler, userAgent);
		}

		public ServiceConnection CreateWithWindowsAuthentication(Uri serviceUri, string userName, string password, string domain, string organization, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpClientHandler httpClientHandler, ProductInfoHeaderValue[] userAgent)
		{
			return SDK.ServiceConnection.CreateWithWindowsAuthentication(serviceUri, userName, password, domain, organization, licenseType, httpClientHandler, userAgent);
		}

		public void SetHostId(string hostId)
		{
			return SDK.ServiceConnection.SetHostId(hostId);
		}
    }
}


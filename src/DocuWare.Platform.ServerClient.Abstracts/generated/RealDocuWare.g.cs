using System.Net;
using System.Net.Http.Headers;
using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class RealDocuWare()
    {
		public async Task<IServiceConnection> CreateAsync(Uri serviceUri, string userName, string password, string organization, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpMessageHandler httpClientHandler, ProductInfoHeaderValue[] userAgent)
		{
			return new ServiceConnection(await SDK.ServiceConnection.CreateAsync(serviceUri, userName, password, organization, licenseType, httpClientHandler, userAgent));
		}

		public async Task<IServiceConnection> CreateAsync(Uri serviceUri, string userName, string password, IServiceConnectionLoginData serviceConnectionData)
		{
			return new ServiceConnection(await SDK.ServiceConnection.CreateAsync(serviceUri, userName, password, ((ServiceConnectionLoginData)serviceConnectionData).Obj));
		}

		public async Task<IServiceConnection> CreateTrustedAsync(Uri serviceUri, string impersonatedUser, string trustedUser, string password, string organization, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpMessageHandler httpClientHandler, ProductInfoHeaderValue[] userAgent)
		{
			return new ServiceConnection(await SDK.ServiceConnection.CreateTrustedAsync(serviceUri, impersonatedUser, trustedUser, password, organization, licenseType, httpClientHandler, userAgent));
		}

		public async Task<IServiceConnection> CreateTrustedAsync(Uri serviceUri, string impersonatedUser, string trustedUser, string password, IServiceConnectionLoginData serviceConnectionData)
		{
			return new ServiceConnection(await SDK.ServiceConnection.CreateTrustedAsync(serviceUri, impersonatedUser, trustedUser, password, ((ServiceConnectionLoginData)serviceConnectionData).Obj));
		}

		public async Task<IServiceConnection> CreateAsync(Uri serviceUri, string token, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpMessageHandler httpClientHandler, ProductInfoHeaderValue[] userAgent)
		{
			return new ServiceConnection(await SDK.ServiceConnection.CreateAsync(serviceUri, token, licenseType, httpClientHandler, userAgent));
		}

		public async Task<IServiceConnection> CreateAsync(Uri serviceUri, string token, IServiceConnectionTokenLoginData serviceConnectionTokenLoginData)
		{
			return new ServiceConnection(await SDK.ServiceConnection.CreateAsync(serviceUri, token, ((ServiceConnectionTokenLoginData)serviceConnectionTokenLoginData).Obj));
		}

		public async Task<IIdentityServiceInfo> GetIdentityServiceInfoAsync(Uri serviceUri, IIdentityServiceInfoConnectionData serviceConnectionData)
		{
			return new IdentityServiceInfo(await SDK.ServiceConnection.GetIdentityServiceInfoAsync(serviceUri, ((IdentityServiceInfoConnectionData)serviceConnectionData).Obj));
		}

		public async Task<IServiceConnection> CreateWithJwtAsync(Uri serviceUri, string accessToken, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpMessageHandler httpClientHandler, ProductInfoHeaderValue[] userAgent)
		{
			return new ServiceConnection(await SDK.ServiceConnection.CreateWithJwtAsync(serviceUri, accessToken, licenseType, httpClientHandler, userAgent));
		}

		public async Task<IServiceConnection> CreateWithJwtAsync(Uri serviceUri, string accessToken, IServiceConnectionTokenLoginData serviceConnectionTokenLoginData)
		{
			return new ServiceConnection(await SDK.ServiceConnection.CreateWithJwtAsync(serviceUri, accessToken, ((ServiceConnectionTokenLoginData)serviceConnectionTokenLoginData).Obj));
		}

		public async Task<IServiceConnection> CreateWithJwtAsync(Uri serviceUri, string accessToken, Func<Task<string>> refreshTokenCallback, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpMessageHandler httpClientHandler, ProductInfoHeaderValue[] userAgent)
		{
			return new ServiceConnection(await SDK.ServiceConnection.CreateWithJwtAsync(serviceUri, accessToken, refreshTokenCallback, licenseType, httpClientHandler, userAgent));
		}

		public async Task<IServiceConnection> CreateWithJwtAsync(Uri serviceUri, string accessToken, IServiceConnectionTokenLoginData serviceConnectionTokenLoginData, Func<Task<string>> refreshTokenCallback)
		{
			return new ServiceConnection(await SDK.ServiceConnection.CreateWithJwtAsync(serviceUri, accessToken, ((ServiceConnectionTokenLoginData)serviceConnectionTokenLoginData).Obj, refreshTokenCallback));
		}

		public async Task<IServiceConnection> CreateAsync(Uri serviceUri, HttpMessageHandler httpClientHandler, ProductInfoHeaderValue[] userAgent)
		{
			return new ServiceConnection(await SDK.ServiceConnection.CreateAsync(serviceUri, httpClientHandler, userAgent));
		}

		public async Task<IServiceConnection> CreateAsync(Uri serviceUri, IServiceConnectionTransportData serviceConnectionTransportData)
		{
			return new ServiceConnection(await SDK.ServiceConnection.CreateAsync(serviceUri, ((ServiceConnectionTransportData)serviceConnectionTransportData).Obj));
		}

		public async Task<IServiceConnection> CreateWithWindowsAuthenticationAsync(Uri serviceUri, ICredentials credentials, string organization, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpClientHandler httpClientHandler, ProductInfoHeaderValue[] userAgent)
		{
			return new ServiceConnection(await SDK.ServiceConnection.CreateWithWindowsAuthenticationAsync(serviceUri, credentials, organization, licenseType, httpClientHandler, userAgent));
		}

		public async Task<IServiceConnection> CreateWithWindowsAuthenticationAsync(Uri serviceUri, ICredentials credentials, IServiceConnectionLoginData serviceConnectionLoginData)
		{
			return new ServiceConnection(await SDK.ServiceConnection.CreateWithWindowsAuthenticationAsync(serviceUri, credentials, ((ServiceConnectionLoginData)serviceConnectionLoginData).Obj));
		}

		public async Task<IServiceConnection> CreateWithWindowsAuthenticationAsync(Uri serviceUri, string userName, string password, string domain, string organization, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpClientHandler httpClientHandler, ProductInfoHeaderValue[] userAgent)
		{
			return new ServiceConnection(await SDK.ServiceConnection.CreateWithWindowsAuthenticationAsync(serviceUri, userName, password, domain, organization, licenseType, httpClientHandler, userAgent));
		}

		public async Task<IServiceConnection> CreateWithWindowsAuthenticationAsync(Uri serviceUri, string userName, string password, string domain, IServiceConnectionLoginData serviceConnectionLoginData)
		{
			return new ServiceConnection(await SDK.ServiceConnection.CreateWithWindowsAuthenticationAsync(serviceUri, userName, password, domain, ((ServiceConnectionLoginData)serviceConnectionLoginData).Obj));
		}

		public async Task<IServiceConnection> CreateWithWindowsAuthenticationAsync(Uri serviceUri, string userName, string password, IServiceConnectionLoginData serviceConnectionLoginData)
		{
			return new ServiceConnection(await SDK.ServiceConnection.CreateWithWindowsAuthenticationAsync(serviceUri, userName, password, ((ServiceConnectionLoginData)serviceConnectionLoginData).Obj));
		}

		public IServiceConnection Create(Uri serviceUri, string userName, string password, string organization, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpMessageHandler httpClientHandler, ProductInfoHeaderValue[] userAgent)
		{
			return new ServiceConnection(SDK.ServiceConnection.Create(serviceUri, userName, password, organization, licenseType, httpClientHandler, userAgent));
		}

		public IServiceConnection CreateTrusted(Uri serviceUri, string impersonatedUser, string trustedUser, string password, string organization, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpMessageHandler httpClientHandler, ProductInfoHeaderValue[] userAgent)
		{
			return new ServiceConnection(SDK.ServiceConnection.CreateTrusted(serviceUri, impersonatedUser, trustedUser, password, organization, licenseType, httpClientHandler, userAgent));
		}

		public IServiceConnection Create(Uri serviceUri, string token, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpMessageHandler httpClientHandler, ProductInfoHeaderValue[] userAgent)
		{
			return new ServiceConnection(SDK.ServiceConnection.Create(serviceUri, token, licenseType, httpClientHandler, userAgent));
		}

		public IServiceConnection Create(Uri serviceUri, HttpMessageHandler httpClientHandler, ProductInfoHeaderValue[] userAgent)
		{
			return new ServiceConnection(SDK.ServiceConnection.Create(serviceUri, httpClientHandler, userAgent));
		}

		public IServiceConnection CreateWithWindowsAuthentication(Uri serviceUri, ICredentials credentials, string organization, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpClientHandler httpClientHandler, ProductInfoHeaderValue[] userAgent)
		{
			return new ServiceConnection(SDK.ServiceConnection.CreateWithWindowsAuthentication(serviceUri, credentials, organization, licenseType, httpClientHandler, userAgent));
		}

		public IServiceConnection CreateWithWindowsAuthentication(Uri serviceUri, string userName, string password, string domain, string organization, DocuWare.Platform.ServerClient.DWProductTypes? licenseType, HttpClientHandler httpClientHandler, ProductInfoHeaderValue[] userAgent)
		{
			return new ServiceConnection(SDK.ServiceConnection.CreateWithWindowsAuthentication(serviceUri, userName, password, domain, organization, licenseType, httpClientHandler, userAgent));
		}

		public void SetHostId(string hostId) => SDK.ServiceConnection.SetHostId(hostId);
    }
}


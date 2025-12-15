using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IIdentityServiceInfo
    {
		string IdentityServiceUrl { get; set; }
		bool RefreshTokenSupported { get; set; }
    }
}

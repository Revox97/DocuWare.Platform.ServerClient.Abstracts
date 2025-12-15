using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ILoginInfo
    {
		string PasswordExpireNotification { get; set; }
		DWProductTypes BookedLicense { get; set; }
		DWProductTypes ProductType { get; set; }
    }
}

using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ILoginInfo
    {
		string PasswordExpireNotification { get; set; }
		DocuWare.Platform.ServerClient.DWProductTypes BookedLicense { get; set; }
		DocuWare.Platform.ServerClient.DWProductTypes ProductType { get; set; }
    }
}

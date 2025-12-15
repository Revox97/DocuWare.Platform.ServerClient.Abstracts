using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IServiceConnectionLoginData
    {
		string Organization { get; set; }
		IServiceConnectionTransportData Transport { get; set; }
		DWProductTypes? LicenseType { get; set; }
    }
}

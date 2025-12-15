using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IServiceConnectionLicenseBoundData
    {
		IServiceConnectionTransportData Transport { get; set; }
		DWProductTypes? LicenseType { get; set; }
    }
}

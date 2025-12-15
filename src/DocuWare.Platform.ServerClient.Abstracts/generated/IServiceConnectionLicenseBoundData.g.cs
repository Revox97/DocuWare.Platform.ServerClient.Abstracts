using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IServiceConnectionLicenseBoundData
    {
		IServiceConnectionTransportData Transport { get; set; }
		DocuWare.Platform.ServerClient.DWProductTypes? LicenseType { get; set; }
    }
}

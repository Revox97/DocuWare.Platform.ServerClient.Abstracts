using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ServiceConnectionLicenseBoundData(DocuWare.Platform.ServerClient.ServiceConnectionLicenseBoundData obj) : IServiceConnectionLicenseBoundData
    {
        internal DocuWare.Platform.ServerClient.ServiceConnectionLicenseBoundData Obj { get; } = obj;
    }
}

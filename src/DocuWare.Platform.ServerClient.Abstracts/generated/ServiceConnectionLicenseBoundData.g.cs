using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ServiceConnectionLicenseBoundData(SDK.ServiceConnectionLicenseBoundData obj) : IServiceConnectionLicenseBoundData
    {
        internal SDK.ServiceConnectionLicenseBoundData Obj { get; } = obj;
    }
}

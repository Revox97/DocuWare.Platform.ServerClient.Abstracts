using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ServiceConnectionTransportData(SDK.ServiceConnectionTransportData obj) : IServiceConnectionTransportData
    {
        internal SDK.ServiceConnectionTransportData Obj { get; } = obj;
    }
}

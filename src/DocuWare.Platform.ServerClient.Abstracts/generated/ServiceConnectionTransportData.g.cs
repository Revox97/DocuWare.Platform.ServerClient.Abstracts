using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ServiceConnectionTransportData(DocuWare.Platform.ServerClient.ServiceConnectionTransportData obj) : IServiceConnectionTransportData
    {
        internal DocuWare.Platform.ServerClient.ServiceConnectionTransportData Obj { get; } = obj;
    }
}

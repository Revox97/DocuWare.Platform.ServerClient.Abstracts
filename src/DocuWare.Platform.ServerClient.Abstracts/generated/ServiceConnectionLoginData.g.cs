using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ServiceConnectionLoginData(SDK.ServiceConnectionLoginData obj) : IServiceConnectionLoginData
    {
        internal SDK.ServiceConnectionLoginData Obj { get; } = obj;
    }
}

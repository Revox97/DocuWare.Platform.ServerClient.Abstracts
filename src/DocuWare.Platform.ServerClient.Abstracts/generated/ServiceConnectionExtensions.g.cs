using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ServiceConnectionExtensions(SDK.ServiceConnectionExtensions obj) : IServiceConnectionExtensions
    {
        internal SDK.ServiceConnectionExtensions Obj { get; } = obj;
    }
}

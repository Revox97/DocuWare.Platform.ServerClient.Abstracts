using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ServiceConnectionExtensions(DocuWare.Platform.ServerClient.ServiceConnectionExtensions obj) : IServiceConnectionExtensions
    {
        internal DocuWare.Platform.ServerClient.ServiceConnectionExtensions Obj { get; } = obj;
    }
}

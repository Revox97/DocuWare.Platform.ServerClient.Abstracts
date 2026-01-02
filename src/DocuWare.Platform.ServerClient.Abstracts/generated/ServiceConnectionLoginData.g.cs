using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ServiceConnectionLoginData(DocuWare.Platform.ServerClient.ServiceConnectionLoginData obj) : IServiceConnectionLoginData
    {
        internal DocuWare.Platform.ServerClient.ServiceConnectionLoginData Obj { get; } = obj;
    }
}

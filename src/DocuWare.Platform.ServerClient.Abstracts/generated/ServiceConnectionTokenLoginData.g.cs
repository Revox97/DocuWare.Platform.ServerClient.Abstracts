using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ServiceConnectionTokenLoginData(DocuWare.Platform.ServerClient.ServiceConnectionTokenLoginData obj) : IServiceConnectionTokenLoginData
    {
        internal DocuWare.Platform.ServerClient.ServiceConnectionTokenLoginData Obj { get; } = obj;
    }
}

using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ServiceConnectionTokenLoginData(SDK.ServiceConnectionTokenLoginData obj) : IServiceConnectionTokenLoginData
    {
        internal SDK.ServiceConnectionTokenLoginData Obj { get; } = obj;
    }
}

using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ClientTimeoutException(SDK.ClientTimeoutException obj) : IClientTimeoutException
    {
        internal SDK.ClientTimeoutException Obj { get; } = obj;

        public string Message => Obj.Message;

        public IDictionary Data => Obj.Data;
    }
}

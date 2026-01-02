using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ClientTimeoutException(DocuWare.Platform.ServerClient.Exceptions.ClientTimeoutException obj) : IClientTimeoutException
    {
        internal DocuWare.Platform.ServerClient.Exceptions.ClientTimeoutException Obj { get; } = obj;

        public string Message => Obj.Message;

        public IDictionary Data => Obj.Data;
    }
}

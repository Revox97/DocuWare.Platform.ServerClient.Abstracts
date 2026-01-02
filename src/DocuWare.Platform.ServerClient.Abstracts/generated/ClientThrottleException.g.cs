using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ClientThrottleException(DocuWare.Platform.ServerClient.Exceptions.ClientThrottleException obj) : IClientThrottleException
    {
        internal DocuWare.Platform.ServerClient.Exceptions.ClientThrottleException Obj { get; } = obj;

        public IDictionary Data => Obj.Data;
    }
}

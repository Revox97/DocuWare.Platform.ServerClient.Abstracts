using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ClientThrottleException(SDK.ClientThrottleException obj) : IClientThrottleException
    {
        internal SDK.ClientThrottleException Obj { get; } = obj;

        public IDictionary Data => Obj.Data;
    }
}

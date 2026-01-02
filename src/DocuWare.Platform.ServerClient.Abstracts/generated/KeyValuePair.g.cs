using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class KeyValuePair(SDK.KeyValuePair obj) : IKeyValuePair
    {
        internal SDK.KeyValuePair Obj { get; } = obj;
    }
}

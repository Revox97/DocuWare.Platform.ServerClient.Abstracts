using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class KeyValuePair(DocuWare.Platform.ServerClient.Content.KeyValuePair obj) : IKeyValuePair
    {
        internal DocuWare.Platform.ServerClient.Content.KeyValuePair Obj { get; } = obj;
    }
}

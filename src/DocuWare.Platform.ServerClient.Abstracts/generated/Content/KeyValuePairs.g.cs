using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts.Content
{
    public class KeyValuePairs(SDK.Content.KeyValuePairs obj) : IKeyValuePairs
    {
        internal SDK.Content.KeyValuePairs Obj { get; } = obj;

        public List<IKeyValuePair> Entry
        {
            get => Obj.Entry.Select(x => new DocuWare.Platform.ServerClient.Abstracts.Content.KeyValuePair(x) as IKeyValuePair).ToList();
            set => Obj.Entry = value.Select(x => ((DocuWare.Platform.ServerClient.Abstracts.Content.KeyValuePair)x).Obj).ToList();
        }
    }
}

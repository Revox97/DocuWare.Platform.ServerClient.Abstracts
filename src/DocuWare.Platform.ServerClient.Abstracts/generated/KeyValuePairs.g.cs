using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class KeyValuePairs(DocuWare.Platform.ServerClient.Content.KeyValuePairs obj) : IKeyValuePairs
    {
        internal DocuWare.Platform.ServerClient.Content.KeyValuePairs Obj { get; } = obj;

        public List<IKeyValuePair> Entry
        {
            get => Obj.Entry.Select(x => new KeyValuePair(x) as IKeyValuePair).ToList();
            set => Obj.Entry = value.Select(x => ((KeyValuePair)x).Obj).ToList();
        }
    }
}

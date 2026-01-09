using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IKeyValuePairs
    {
		List<IKeyValuePair> Entry { get; set; }
    }
}

using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ICountResultItem
    {
		string Name { get; set; }
		int Count { get; set; }
    }
}

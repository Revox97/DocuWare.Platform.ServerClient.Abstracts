using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFieldMapping
    {
		string Source { get; set; }
		string Destination { get; set; }
    }
}

using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IAdhocRenderingQuery
    {
		IDWSize Size { get; set; }
		int Page { get; set; }
		float Dpi { get; set; }
		string ApiKey { get; set; }
    }
}

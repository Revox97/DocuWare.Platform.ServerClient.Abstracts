using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IAdhocRenderingQuery{3}
    {
		int Page { get; set; }
		float Dpi { get; set; }
		string ApiKey { get; set; }
    }
}

using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFormTemplate
    {
		string TemplateGUID { get; set; }
		string FileName { get; set; }
		List<IZone> Zones { get; set; }
		List<string> ExcludedFileAttachments { get; set; }
    }
}

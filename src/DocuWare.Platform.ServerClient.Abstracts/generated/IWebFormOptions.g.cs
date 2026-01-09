using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IWebFormOptions
    {
		List<IWebFormOption> WebFormOption { get; set; }
    }
}

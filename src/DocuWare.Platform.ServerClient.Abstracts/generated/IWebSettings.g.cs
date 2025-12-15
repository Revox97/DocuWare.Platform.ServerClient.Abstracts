using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IWebSettings
    {
		List<IApplicationPreferences> ApplicationPreferences { get; set; }
    }
}

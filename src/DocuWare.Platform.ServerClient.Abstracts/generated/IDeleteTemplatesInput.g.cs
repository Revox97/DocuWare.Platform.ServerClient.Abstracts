using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDeleteTemplatesInput
    {
		List<string> TemplateGUIDS { get; set; }
    }
}

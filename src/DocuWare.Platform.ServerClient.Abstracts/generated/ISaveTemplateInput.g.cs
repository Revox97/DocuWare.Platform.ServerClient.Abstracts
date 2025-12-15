using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISaveTemplateInput
    {
		List<IFormTemplate> Templates { get; set; }
    }
}

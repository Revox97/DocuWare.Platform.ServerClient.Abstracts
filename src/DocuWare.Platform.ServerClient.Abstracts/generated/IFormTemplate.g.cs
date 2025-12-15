using DocuWare.Platform.ServerClient;

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

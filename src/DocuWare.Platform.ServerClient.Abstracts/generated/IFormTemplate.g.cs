using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFormTemplate
    {
		List<IZone> Zones { get; set; }
		List<string> ExcludedFileAttachments { get; set; }
    }
}

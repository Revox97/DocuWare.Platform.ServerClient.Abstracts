using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentAnnotationsPlacement
    {
		List<ISectionAnnotationsPlacement> Annotations { get; set; }
    }
}

using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentAnnotations
    {
		List<ISectionAnnotation> Annotations { get; set; }
    }
}

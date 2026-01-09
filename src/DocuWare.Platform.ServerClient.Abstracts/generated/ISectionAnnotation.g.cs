using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISectionAnnotation{3}
    {
		List<ILayer> Annotation { get; set; }
		int SectionNumber { get; set; }
		int PageNumber { get; set; }
    }
}

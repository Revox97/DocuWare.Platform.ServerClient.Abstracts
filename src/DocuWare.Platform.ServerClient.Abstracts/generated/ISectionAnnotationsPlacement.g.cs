using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISectionAnnotationsPlacement{3}
    {
		IAnnotationsPlacement AnnotationsPlacement { get; set; }
		int SectionNumber { get; set; }
		int PageNumber { get; set; }
    }
}

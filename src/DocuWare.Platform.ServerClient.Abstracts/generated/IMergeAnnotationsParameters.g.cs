using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IMergeAnnotationsParameters: IDocumentActionParameters
    {
		int SectionNumber { get; set; }
    }
}

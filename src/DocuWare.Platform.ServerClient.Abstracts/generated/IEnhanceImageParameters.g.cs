using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IEnhanceImageParameters : IDocumentActionParameters
    {
		int SectionNumber { get; set; }
    }
}

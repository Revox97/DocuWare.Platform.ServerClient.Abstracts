using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IRotatePageParameters : IDocumentActionParameters
    {
		int SectionNumber { get; set; }
		int PageNumber { get; set; }
		int Rotation { get; set; }
    }
}

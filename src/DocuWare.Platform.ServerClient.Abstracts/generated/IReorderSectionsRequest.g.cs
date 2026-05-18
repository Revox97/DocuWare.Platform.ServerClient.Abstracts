using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IReorderSectionsRequest
    {
		List<string> SectionId { get; set; }
    }
}

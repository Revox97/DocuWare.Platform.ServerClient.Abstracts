using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentIndexFields
    {
		List<IDocumentIndexField> Field { get; set; }
    }
}

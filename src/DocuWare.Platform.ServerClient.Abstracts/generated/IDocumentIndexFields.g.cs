using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentIndexFields
    {
		IDocumentIndexField Item { get; set; }
		List<IDocumentIndexField> Field { get; set; }
    }
}

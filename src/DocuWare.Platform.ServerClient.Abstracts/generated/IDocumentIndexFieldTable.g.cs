using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentIndexFieldTable
    {
		List<IDocumentIndexFieldTableRow> Row { get; set; }
    }
}

using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentAuditEventTablePropertyValues
    {
		List<List<string>> Row { get; set; }
    }
}

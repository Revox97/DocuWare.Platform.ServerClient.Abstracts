using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentAuditEventTableProperty
    {
		List<IDocumentAuditEventTablePropertyColumn> Column { get; set; }
		List<List<string>> OldValues { get; set; }
		List<List<string>> NewValues { get; set; }
		string PropertyName { get; set; }
    }
}

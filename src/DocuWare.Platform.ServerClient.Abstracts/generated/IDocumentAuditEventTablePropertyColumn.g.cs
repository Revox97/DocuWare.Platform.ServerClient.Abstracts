using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentAuditEventTablePropertyColumn
    {
		string Name { get; set; }
		DWFieldType Type { get; set; }
    }
}

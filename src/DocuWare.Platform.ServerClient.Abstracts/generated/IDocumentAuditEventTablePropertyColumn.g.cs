using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentAuditEventTablePropertyColumn
    {
		string Name { get; set; }
		DocuWare.Platform.ServerClient.DWFieldType Type { get; set; }
    }
}

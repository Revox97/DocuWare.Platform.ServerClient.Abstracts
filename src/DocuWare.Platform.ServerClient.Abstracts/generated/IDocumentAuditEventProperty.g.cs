using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentAuditEventProperty
    {
		string PropertyName { get; set; }
		string OldValue { get; set; }
		string NewValue { get; set; }
		DocuWare.Platform.ServerClient.DWFieldType DWFieldType { get; set; }
    }
}

using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentAuditEventProperty{3}
    {
		string PropertyName { get; set; }
		string OldValue { get; set; }
		string NewValue { get; set; }
		DWFieldType DWFieldType { get; set; }
    }
}

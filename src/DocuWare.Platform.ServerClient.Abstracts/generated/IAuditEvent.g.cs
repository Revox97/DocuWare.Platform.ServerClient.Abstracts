using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IAuditEvent{3}
    {
		string Id { get; set; }
		string Event { get; set; }
		string Type { get; set; }
		string Name { get; set; }
		string User { get; set; }
		DateTime Date { get; set; }
    }
}

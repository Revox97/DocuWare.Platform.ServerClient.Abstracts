using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IEventHistoryStep{3}
    {
		string FCName { get; set; }
		string DocId { get; set; }
		string Status { get; set; }
    }
}

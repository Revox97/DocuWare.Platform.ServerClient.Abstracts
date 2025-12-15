using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IReassignHistoryStep
    {
		List<string> RecipientsName { get; set; }
		string Subject { get; set; }
		bool SendMail { get; set; }
		string UserName { get; set; }
    }
}

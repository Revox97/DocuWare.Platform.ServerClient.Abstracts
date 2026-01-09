using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IRequestEndHistoryStep
    {
		string UserName { get; set; }
		bool DocumentDeleted { get; set; }
    }
}

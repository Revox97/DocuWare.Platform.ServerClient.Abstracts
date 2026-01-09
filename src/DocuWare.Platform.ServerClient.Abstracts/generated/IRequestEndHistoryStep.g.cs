using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IRequestEndHistoryStep{3}
    {
		string UserName { get; set; }
		bool DocumentDeleted { get; set; }
    }
}

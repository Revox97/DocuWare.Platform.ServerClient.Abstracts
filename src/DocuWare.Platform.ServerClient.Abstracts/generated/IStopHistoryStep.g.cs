using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IStopHistoryStep{3}
    {
		string UserName { get; set; }
		string DocumentUserVersion { get; set; }
		string EndState { get; set; }
		bool DocumentDeleted { get; set; }
    }
}

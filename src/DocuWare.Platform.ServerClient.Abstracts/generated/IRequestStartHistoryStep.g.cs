using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IRequestStartHistoryStep{3}
    {
		string RequestText { get; set; }
		string UserName { get; set; }
		string Title { get; set; }
    }
}

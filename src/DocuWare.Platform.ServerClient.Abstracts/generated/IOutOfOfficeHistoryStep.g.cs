using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IOutOfOfficeHistoryStep
    {
		string NewUser { get; set; }
		string OutOfOfficeUser { get; set; }
    }
}

using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IErrorHistoryStep{3}
    {
		string ErrorMessage { get; set; }
		string FullErrorMessage { get; set; }
		string OutputName { get; set; }
    }
}

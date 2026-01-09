using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IErrorHistoryStep
    {
		string ErrorMessage { get; set; }
		string FullErrorMessage { get; set; }
		string OutputName { get; set; }
    }
}

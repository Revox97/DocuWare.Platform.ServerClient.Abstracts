using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ICsvExpression
    {
		IDialogExpression DialogExpression { get; set; }
		string Delimiter { get; set; }
		bool IsUtc { get; set; }
    }
}

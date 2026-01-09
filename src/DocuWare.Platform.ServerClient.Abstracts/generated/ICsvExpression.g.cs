using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ICsvExpression{3}
    {
		string Delimiter { get; set; }
		bool IsUtc { get; set; }
    }
}

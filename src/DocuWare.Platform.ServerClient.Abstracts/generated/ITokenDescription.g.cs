using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITokenDescription
    {
		List<DocuWare.Platform.ServerClient.DWProductTypes> TargetProducts { get; set; }
		DocuWare.Platform.ServerClient.TokenUsage Usage { get; set; }
		string Lifetime { get; set; }
    }
}

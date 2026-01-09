using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITokenDescription
    {
		List<DWProductTypes> TargetProducts { get; set; }
		TokenUsage Usage { get; set; }
		string Lifetime { get; set; }
    }
}

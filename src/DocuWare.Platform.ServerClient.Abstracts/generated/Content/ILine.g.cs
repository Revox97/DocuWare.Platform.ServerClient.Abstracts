using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts.Content
{
    public interface ILine : IRectangleBase
    {
		List<object> Items { get; set; }
		bool bold { get; set; }
		int fontSize { get; set; }
		int BaseLine { get; set; }
    }
}

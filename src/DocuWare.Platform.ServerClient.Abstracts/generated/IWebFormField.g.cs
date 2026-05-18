using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IWebFormField : IWebFormControl
    {
		string Value { get; set; }
		string Type { get; set; }
		bool Hidden { get; set; }
		bool Readonly { get; set; }
		bool Required { get; set; }
		string Hint { get; set; }
		string ValidationID { get; set; }
    }
}

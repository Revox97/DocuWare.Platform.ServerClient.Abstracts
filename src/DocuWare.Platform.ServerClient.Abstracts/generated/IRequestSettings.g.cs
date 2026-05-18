using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IRequestSettings
    {
		List<IRequestDecisionSettings> Decisions { get; set; }
		List<IAssignedItem> AssignedItem { get; set; }
		string Name { get; set; }
		string Description { get; set; }
		bool IsSequence { get; set; }
		bool IsAny { get; set; }
		int DocId { get; set; }
		string FcGuid { get; set; }
		string DocumentName { get; set; }
		bool StampDocument { get; set; }
		bool SkipEmailSending { get; set; }
    }
}

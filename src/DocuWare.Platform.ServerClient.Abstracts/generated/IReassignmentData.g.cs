using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IReassignmentData
    {
		List<IAssignedItem> ReassignmentList { get; set; }
		string Subject { get; set; }
		string Body { get; set; }
		bool SendEmail { get; set; }
    }
}

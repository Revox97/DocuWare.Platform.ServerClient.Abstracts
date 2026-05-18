using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ICountResult
    {
		List<ICountResultItem> Group { get; set; }
		DateTime TimeStamp { get; set; }
		string FileCabinetId { get; set; }
		string OrganizationGuid { get; set; }
		string LastAccessUser { get; set; }
    }
}

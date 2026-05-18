using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ICFSStatisticSpecific
    {
		List<ICFSSpecificValue> SpecificValue { get; set; }
		CFSTableNames Category { get; set; }
		string ObjectID { get; set; }
    }
}

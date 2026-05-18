using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDialogInfos
    {
		List<IDialogInfo> Dialog { get; set; }
		Link[] Links { get; set; }

		void SetProxy(HttpClientProxy proxy);
		IDialogInfos GetDialogInfosFromSelfRelation();
		Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromSelfRelationAsync();
		Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromSelfRelationAsync(CancellationToken cancellationToken);
    }
}

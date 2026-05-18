using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISelectListInfo
    {
		Link[] Links { get; set; }
		string Guid { get; set; }
		string Name { get; set; }
		SelectListKind Kind { get; set; }

		void SetProxy(HttpClientProxy proxy);
		ISelectListValuesResult GetSelectListValuesResultFromValuesRelation();
		Task<DeserializedHttpResponse<ISelectListValuesResult>> GetSelectListValuesResultFromValuesRelationAsync();
		Task<DeserializedHttpResponse<ISelectListValuesResult>> GetSelectListValuesResultFromValuesRelationAsync(CancellationToken cancellationToken);
		ISelectListValuesResult PostToValuesRelationForSelectListValuesResult(ISelectListValuesQuery dataToSend);
		Task<DeserializedHttpResponse<ISelectListValuesResult>> PostToValuesRelationForSelectListValuesResultAsync(ISelectListValuesQuery dataToSend);
		Task<DeserializedHttpResponse<ISelectListValuesResult>> PostToValuesRelationForSelectListValuesResultAsync(CancellationToken cancellationToken, ISelectListValuesQuery dataToSend);
		IAreValuesInSelectListsResult PostToContainsRelationForAreValuesInSelectListsResult(ISelectListValuesToCheck dataToSend);
		Task<DeserializedHttpResponse<IAreValuesInSelectListsResult>> PostToContainsRelationForAreValuesInSelectListsResultAsync(ISelectListValuesToCheck dataToSend);
		Task<DeserializedHttpResponse<IAreValuesInSelectListsResult>> PostToContainsRelationForAreValuesInSelectListsResultAsync(CancellationToken cancellationToken, ISelectListValuesToCheck dataToSend);
    }
}

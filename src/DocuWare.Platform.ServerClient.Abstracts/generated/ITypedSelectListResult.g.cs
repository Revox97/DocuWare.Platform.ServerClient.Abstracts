using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITypedSelectListResult
    {
		List<IDocumentIndexFieldValue> Value { get; set; }
		Link[] Links { get; set; }

		void SetProxy(HttpClientProxy proxy);
		ITypedSelectListResult GetTypedSelectListResultFromNextRelation();
		Task<DeserializedHttpResponse<ITypedSelectListResult>> GetTypedSelectListResultFromNextRelationAsync();
		Task<DeserializedHttpResponse<ITypedSelectListResult>> GetTypedSelectListResultFromNextRelationAsync(CancellationToken cancellationToken);
		ITypedSelectListResult GetTypedSelectListResultFromPrevRelation();
		Task<DeserializedHttpResponse<ITypedSelectListResult>> GetTypedSelectListResultFromPrevRelationAsync();
		Task<DeserializedHttpResponse<ITypedSelectListResult>> GetTypedSelectListResultFromPrevRelationAsync(CancellationToken cancellationToken);
		ITypedSelectListResult GetTypedSelectListResultFromSelfRelation();
		Task<DeserializedHttpResponse<ITypedSelectListResult>> GetTypedSelectListResultFromSelfRelationAsync();
		Task<DeserializedHttpResponse<ITypedSelectListResult>> GetTypedSelectListResultFromSelfRelationAsync(CancellationToken cancellationToken);
		ITypedSelectListResult GetTypedSelectListResultFromFirstRelation();
		Task<DeserializedHttpResponse<ITypedSelectListResult>> GetTypedSelectListResultFromFirstRelationAsync();
		Task<DeserializedHttpResponse<ITypedSelectListResult>> GetTypedSelectListResultFromFirstRelationAsync(CancellationToken cancellationToken);
    }
}

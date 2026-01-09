using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISingleColumnSelectListValues{3}
    {
		List<string> Value { get; set; }
		List<IDocumentIndexFieldValue> TypedValue { get; set; }
		Link[] Links { get; set; }
		string NextRelationLink { get; }
		string PrevRelationLink { get; }
		string SelfRelationLink { get; }
		string FirstRelationLink { get; }

		void SetProxy(HttpClientProxy proxy);
		ISingleColumnSelectListValues GetSingleColumnSelectListValuesFromNextRelation();
		Task<DeserializedHttpResponse<ISingleColumnSelectListValues>> GetSingleColumnSelectListValuesFromNextRelationAsync();
		Task<DeserializedHttpResponse<ISingleColumnSelectListValues>> GetSingleColumnSelectListValuesFromNextRelationAsync(CancellationToken cancellationToken);
		ISingleColumnSelectListValues GetSingleColumnSelectListValuesFromPrevRelation();
		Task<DeserializedHttpResponse<ISingleColumnSelectListValues>> GetSingleColumnSelectListValuesFromPrevRelationAsync();
		Task<DeserializedHttpResponse<ISingleColumnSelectListValues>> GetSingleColumnSelectListValuesFromPrevRelationAsync(CancellationToken cancellationToken);
		ISingleColumnSelectListValues GetSingleColumnSelectListValuesFromSelfRelation();
		Task<DeserializedHttpResponse<ISingleColumnSelectListValues>> GetSingleColumnSelectListValuesFromSelfRelationAsync();
		Task<DeserializedHttpResponse<ISingleColumnSelectListValues>> GetSingleColumnSelectListValuesFromSelfRelationAsync(CancellationToken cancellationToken);
		ISingleColumnSelectListValues GetSingleColumnSelectListValuesFromFirstRelation();
		Task<DeserializedHttpResponse<ISingleColumnSelectListValues>> GetSingleColumnSelectListValuesFromFirstRelationAsync();
		Task<DeserializedHttpResponse<ISingleColumnSelectListValues>> GetSingleColumnSelectListValuesFromFirstRelationAsync(CancellationToken cancellationToken);
    }
}

using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IMultiColSelectListValuesResult
    {
		List<IMultiColSelectListColumn> Columns { get; set; }
		List<IMultiColSelectListRow> Rows { get; set; }
		Link[] Links { get; set; }

		void SetProxy(HttpClientProxy proxy);
		IMultiColSelectListValuesResult GetMultiColSelectListValuesResultFromNextRelation();
		Task<DeserializedHttpResponse<IMultiColSelectListValuesResult>> GetMultiColSelectListValuesResultFromNextRelationAsync();
		Task<DeserializedHttpResponse<IMultiColSelectListValuesResult>> GetMultiColSelectListValuesResultFromNextRelationAsync(CancellationToken cancellationToken);
		IMultiColSelectListValuesResult GetMultiColSelectListValuesResultFromPrevRelation();
		Task<DeserializedHttpResponse<IMultiColSelectListValuesResult>> GetMultiColSelectListValuesResultFromPrevRelationAsync();
		Task<DeserializedHttpResponse<IMultiColSelectListValuesResult>> GetMultiColSelectListValuesResultFromPrevRelationAsync(CancellationToken cancellationToken);
		IMultiColSelectListValuesResult GetMultiColSelectListValuesResultFromSelfRelation();
		Task<DeserializedHttpResponse<IMultiColSelectListValuesResult>> GetMultiColSelectListValuesResultFromSelfRelationAsync();
		Task<DeserializedHttpResponse<IMultiColSelectListValuesResult>> GetMultiColSelectListValuesResultFromSelfRelationAsync(CancellationToken cancellationToken);
		IMultiColSelectListValuesResult GetMultiColSelectListValuesResultFromFirstRelation();
		Task<DeserializedHttpResponse<IMultiColSelectListValuesResult>> GetMultiColSelectListValuesResultFromFirstRelationAsync();
		Task<DeserializedHttpResponse<IMultiColSelectListValuesResult>> GetMultiColSelectListValuesResultFromFirstRelationAsync(CancellationToken cancellationToken);
    }
}

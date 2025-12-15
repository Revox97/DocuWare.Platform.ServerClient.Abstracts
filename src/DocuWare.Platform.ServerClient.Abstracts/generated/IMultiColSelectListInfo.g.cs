using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IMultiColSelectListInfo
    {
		Link[] Links { get; set; }
		List<string> Columns { get; set; }
		string Guid { get; set; }
		string Name { get; set; }
		SelectListKind Kind { get; set; }
		string ValuesRelationLink { get; }

		void SetProxy(HttpClientProxy proxy);
		IMultiColSelectListValuesResult GetMultiColSelectListValuesResultFromValuesRelation();
		Task<DeserializedHttpResponse<IMultiColSelectListValuesResult>> GetMultiColSelectListValuesResultFromValuesRelationAsync();
		Task<DeserializedHttpResponse<IMultiColSelectListValuesResult>> GetMultiColSelectListValuesResultFromValuesRelationAsync(CancellationToken cancellationToken);
		IMultiColSelectListValuesResult PostToValuesRelationForMultiColSelectListValuesResult(IMultiColSelectListValuesQuery dataToSend);
		Task<DeserializedHttpResponse<IMultiColSelectListValuesResult>> PostToValuesRelationForMultiColSelectListValuesResultAsync(IMultiColSelectListValuesQuery dataToSend);
		Task<DeserializedHttpResponse<IMultiColSelectListValuesResult>> PostToValuesRelationForMultiColSelectListValuesResultAsync(CancellationToken cancellationToken, IMultiColSelectListValuesQuery dataToSend);
    }
}

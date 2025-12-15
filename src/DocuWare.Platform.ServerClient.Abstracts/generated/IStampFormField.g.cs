using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IStampFormField
    {
		Link[] Links { get; set; }
		string Name { get; set; }
		string Label { get; set; }
		int Length { get; set; }
		int Precision { get; set; }
		DocuWare.Platform.ServerClient.DWFieldType DWFieldType { get; set; }
		string Mask { get; set; }
		string MaskErrorText { get; set; }
		string SampleEditText { get; set; }
		bool SelectListsAssigned { get; set; }
		bool NotEmpty { get; set; }
		string SelectListValuesRelationLink { get; }
		string SimpleSelectListRelationLink { get; }

		void SetProxy(HttpClientProxy proxy);
		ISelectListResult GetSelectListResultFromSelectListValuesRelation();
		Task<DeserializedHttpResponse<ISelectListResult>> GetSelectListResultFromSelectListValuesRelationAsync();
		Task<DeserializedHttpResponse<ISelectListResult>> GetSelectListResultFromSelectListValuesRelationAsync(CancellationToken cancellationToken);
		ISelectListResult PostToSelectListValuesRelationForSelectListResult(ISelectListExpression dataToSend);
		Task<DeserializedHttpResponse<ISelectListResult>> PostToSelectListValuesRelationForSelectListResultAsync(ISelectListExpression dataToSend);
		Task<DeserializedHttpResponse<ISelectListResult>> PostToSelectListValuesRelationForSelectListResultAsync(CancellationToken cancellationToken, ISelectListExpression dataToSend);
		ISelectListResult GetSelectListResultFromSimpleSelectListRelation();
		Task<DeserializedHttpResponse<ISelectListResult>> GetSelectListResultFromSimpleSelectListRelationAsync();
		Task<DeserializedHttpResponse<ISelectListResult>> GetSelectListResultFromSimpleSelectListRelationAsync(CancellationToken cancellationToken);
		ISelectListResult PostToSimpleSelectListRelationForSelectListResult(ISelectListExpression dataToSend);
		Task<DeserializedHttpResponse<ISelectListResult>> PostToSimpleSelectListRelationForSelectListResultAsync(ISelectListExpression dataToSend);
		Task<DeserializedHttpResponse<ISelectListResult>> PostToSimpleSelectListRelationForSelectListResultAsync(CancellationToken cancellationToken, ISelectListExpression dataToSend);
    }
}

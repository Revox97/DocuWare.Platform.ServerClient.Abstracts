using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDialogFieldBase
    {
		string Mask { get; set; }
		string MaskErrorText { get; set; }
		string SampleEditText { get; set; }
		List<IDocumentIndexFieldValue> PrefillValue { get; set; }
		List<DocuWare.Platform.ServerClient.DynamicValueType> DynamicPrefillValue { get; set; }
		List<ISelectListInfo> SelectListInfos { get; set; }
		Link[] Links { get; set; }
		string DBFieldName { get; set; }
		string DlgLabel { get; set; }
		DocuWare.Platform.ServerClient.DWFieldType DWFieldType { get; set; }
		bool Locked { get; set; }
		bool ReadOnly { get; set; }
		bool NotEmpty { get; set; }
		bool Visible { get; set; }
		int Length { get; set; }
		int Precision { get; set; }
		bool AllowExtendedSearch { get; set; }
		bool AllowFiltering { get; set; }
		bool SelectListOnly { get; set; }
		DocuWare.Platform.ServerClient.SelectListType SelectListType { get; set; }
		bool AssignedInternalSelectList { get; set; }
		string SequenceId { get; set; }
		bool SelectListsAssigned { get; set; }
		bool CalculateSum { get; set; }
		string SimpleSelectListRelationLink { get; }

		void SetProxy(HttpClientProxy proxy);
		ISelectListResult GetSelectListResultFromSimpleSelectListRelation();
		Task<DeserializedHttpResponse<ISelectListResult>> GetSelectListResultFromSimpleSelectListRelationAsync();
		Task<DeserializedHttpResponse<ISelectListResult>> GetSelectListResultFromSimpleSelectListRelationAsync(CancellationToken cancellationToken);
		ISelectListResult PostToSimpleSelectListRelationForSelectListResult(ISelectListExpression dataToSend);
		Task<DeserializedHttpResponse<ISelectListResult>> PostToSimpleSelectListRelationForSelectListResultAsync(ISelectListExpression dataToSend);
		Task<DeserializedHttpResponse<ISelectListResult>> PostToSimpleSelectListRelationForSelectListResultAsync(CancellationToken cancellationToken, ISelectListExpression dataToSend);
    }
}

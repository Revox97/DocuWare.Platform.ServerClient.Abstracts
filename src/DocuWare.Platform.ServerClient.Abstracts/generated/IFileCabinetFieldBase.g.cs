using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFileCabinetFieldBase
    {
		Link[] Links { get; set; }
		string FixedEntry { get; set; }
		string FieldInfoText { get; set; }
		DocuWare.Platform.ServerClient.FileCabinetFieldScope Scope { get; set; }
		DocuWare.Platform.ServerClient.DWFieldType DWFieldType { get; set; }
		int Length { get; set; }
		string DBFieldName { get; set; }
		string DisplayName { get; set; }
		bool DropLeadingZero { get; set; }
		bool DropLeadingBlanks { get; set; }
		bool NotEmpty { get; set; }
		int Precision { get; set; }
		string SelectListRelationLink { get; }

		void SetProxy(HttpClientProxy proxy);
		ISelectListResult GetSelectListResultFromSelectListRelation();
		Task<DeserializedHttpResponse<ISelectListResult>> GetSelectListResultFromSelectListRelationAsync();
		Task<DeserializedHttpResponse<ISelectListResult>> GetSelectListResultFromSelectListRelationAsync(CancellationToken cancellationToken);
		ISelectListResult PostToSelectListRelationForSelectListResult(IFileCabinetSelectListExpression dataToSend);
		Task<DeserializedHttpResponse<ISelectListResult>> PostToSelectListRelationForSelectListResultAsync(IFileCabinetSelectListExpression dataToSend);
		Task<DeserializedHttpResponse<ISelectListResult>> PostToSelectListRelationForSelectListResultAsync(CancellationToken cancellationToken, IFileCabinetSelectListExpression dataToSend);
    }
}

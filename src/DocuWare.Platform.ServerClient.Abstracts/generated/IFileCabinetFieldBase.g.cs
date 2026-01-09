using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFileCabinetFieldBase{3}
    {
		Link[] Links { get; set; }
		FileCabinetFieldScope Scope { get; set; }
		DWFieldType DWFieldType { get; set; }
		int Length { get; set; }
		string DBFieldName { get; set; }
		string DisplayName { get; set; }
		bool DropLeadingZero { get; set; }
		bool DropLeadingBlanks { get; set; }
		bool NotEmpty { get; set; }
		int Precision { get; set; }

		void SetProxy(HttpClientProxy proxy);
		ISelectListResult GetSelectListResultFromSelectListRelation();
		Task<DeserializedHttpResponse<ISelectListResult>> GetSelectListResultFromSelectListRelationAsync();
		Task<DeserializedHttpResponse<ISelectListResult>> GetSelectListResultFromSelectListRelationAsync(CancellationToken cancellationToken);
		ISelectListResult PostToSelectListRelationForSelectListResult(IFileCabinetSelectListExpression dataToSend);
		Task<DeserializedHttpResponse<ISelectListResult>> PostToSelectListRelationForSelectListResultAsync(IFileCabinetSelectListExpression dataToSend);
		Task<DeserializedHttpResponse<ISelectListResult>> PostToSelectListRelationForSelectListResultAsync(CancellationToken cancellationToken, IFileCabinetSelectListExpression dataToSend);
    }
}

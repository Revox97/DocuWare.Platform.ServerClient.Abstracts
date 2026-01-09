using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDialogInfo
    {
		Link[] Links { get; set; }
		string Id { get; set; }
		string FileCabinetId { get; set; }
		string FileCabinetName { get; set; }
		string DisplayName { get; set; }
		bool IsForMobile { get; set; }
		string AssignedDialogId { get; set; }
		string Color { get; set; }
		bool IsDefault { get; set; }
		DialogTypes Type { get; set; }

		void SetProxy(HttpClientProxy proxy);
		IDialog GetDialogFromSelfRelation();
		Task<DeserializedHttpResponse<IDialog>> GetDialogFromSelfRelationAsync();
		Task<DeserializedHttpResponse<IDialog>> GetDialogFromSelfRelationAsync(CancellationToken cancellationToken);
		string DeleteSelfRelation();
		Task<DeserializedHttpResponse<string>> DeleteSelfRelationAsync();
		Task<DeserializedHttpResponse<string>> DeleteSelfRelationAsync(CancellationToken cancellationToken);
		IDialog GetDialogFromAssignedDialogRelation();
		Task<DeserializedHttpResponse<IDialog>> GetDialogFromAssignedDialogRelationAsync();
		Task<DeserializedHttpResponse<IDialog>> GetDialogFromAssignedDialogRelationAsync(CancellationToken cancellationToken);
		ICountResult GetCountResultFromCountRelation();
		Task<DeserializedHttpResponse<ICountResult>> GetCountResultFromCountRelationAsync();
		Task<DeserializedHttpResponse<ICountResult>> GetCountResultFromCountRelationAsync(CancellationToken cancellationToken);
		ICountResult PostToCountRelationForCountResult(ICountExpression dataToSend);
		Task<DeserializedHttpResponse<ICountResult>> PostToCountRelationForCountResultAsync(ICountExpression dataToSend);
		Task<DeserializedHttpResponse<ICountResult>> PostToCountRelationForCountResultAsync(CancellationToken cancellationToken, ICountExpression dataToSend);
		ISelectListResult PostToSelectListRelationForSelectListResult(ISelectListExpression dataToSend);
		Task<DeserializedHttpResponse<ISelectListResult>> PostToSelectListRelationForSelectListResultAsync(ISelectListExpression dataToSend);
		Task<DeserializedHttpResponse<ISelectListResult>> PostToSelectListRelationForSelectListResultAsync(CancellationToken cancellationToken, ISelectListExpression dataToSend);
		IDocument PostToStoreDocumentRelationForDocument(IDocument dataToSend);
		Task<DeserializedHttpResponse<IDocument>> PostToStoreDocumentRelationForDocumentAsync(IDocument dataToSend);
		Task<DeserializedHttpResponse<IDocument>> PostToStoreDocumentRelationForDocumentAsync(CancellationToken cancellationToken, IDocument dataToSend);
		IDocumentsQueryResult PostToTransferRelationForDocumentsQueryResult(IFileCabinetTransferInfo dataToSend);
		Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToTransferRelationForDocumentsQueryResultAsync(IFileCabinetTransferInfo dataToSend);
		Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToTransferRelationForDocumentsQueryResultAsync(CancellationToken cancellationToken, IFileCabinetTransferInfo dataToSend);
		IDocumentsQueryResult PostToTransferRelationForDocumentsQueryResult(IDocumentsTransferInfo dataToSend);
		Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToTransferRelationForDocumentsQueryResultAsync(IDocumentsTransferInfo dataToSend);
		Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToTransferRelationForDocumentsQueryResultAsync(CancellationToken cancellationToken, IDocumentsTransferInfo dataToSend);
		IDialog PostToCreateUserDefinedSearchRelationForDialog(IUserDefinedSearchInfo dataToSend);
		Task<DeserializedHttpResponse<IDialog>> PostToCreateUserDefinedSearchRelationForDialogAsync(IUserDefinedSearchInfo dataToSend);
		Task<DeserializedHttpResponse<IDialog>> PostToCreateUserDefinedSearchRelationForDialogAsync(CancellationToken cancellationToken, IUserDefinedSearchInfo dataToSend);
		string PostToClientSideValidationRelationForString(IDocumentIndexFields dataToSend);
		Task<DeserializedHttpResponse<string>> PostToClientSideValidationRelationForStringAsync(IDocumentIndexFields dataToSend);
		Task<DeserializedHttpResponse<string>> PostToClientSideValidationRelationForStringAsync(CancellationToken cancellationToken, IDocumentIndexFields dataToSend);
    }
}

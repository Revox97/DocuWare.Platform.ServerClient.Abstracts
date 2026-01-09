using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IRequestTask{3}
    {
		Link[] Links { get; set; }
		List<IRequestDecision> Decisions { get; set; }
		string Id { get; set; }
		string WorkflowId { get; set; }
		int DocId { get; set; }
		string FcGuid { get; set; }
		DateTime CreateDate { get; set; }
		string Owner { get; set; }
		string WorkflowName { get; set; }
		string DocumentName { get; set; }
		bool IsRead { get; set; }
		string Description { get; set; }
		bool AllowDecisionStamp { get; set; }

		void SetProxy(HttpClientProxy proxy);
		IRequestTask GetRequestTaskFromSelfRelation();
		Task<DeserializedHttpResponse<IRequestTask>> GetRequestTaskFromSelfRelationAsync();
		Task<DeserializedHttpResponse<IRequestTask>> GetRequestTaskFromSelfRelationAsync(CancellationToken cancellationToken);
		string PutToReadStatusRelationForString(Stream dataToSend);
		Task<DeserializedHttpResponse<string>> PutToReadStatusRelationForStringAsync(Stream dataToSend);
		Task<DeserializedHttpResponse<string>> PutToReadStatusRelationForStringAsync(CancellationToken cancellationToken, Stream dataToSend);
		IInstanceHistory GetInstanceHistoryFromHistoryRelation();
		Task<DeserializedHttpResponse<IInstanceHistory>> GetInstanceHistoryFromHistoryRelationAsync();
		Task<DeserializedHttpResponse<IInstanceHistory>> GetInstanceHistoryFromHistoryRelationAsync(CancellationToken cancellationToken);
		IRequestDecisionsStampSettings GetRequestDecisionsStampSettingsFromStampSettingsRelation();
		Task<DeserializedHttpResponse<IRequestDecisionsStampSettings>> GetRequestDecisionsStampSettingsFromStampSettingsRelationAsync();
		Task<DeserializedHttpResponse<IRequestDecisionsStampSettings>> GetRequestDecisionsStampSettingsFromStampSettingsRelationAsync(CancellationToken cancellationToken);
    }
}

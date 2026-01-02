using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class OwnWorkflow(DocuWare.Platform.ServerClient.OwnWorkflow obj) : IOwnWorkflow
    {
        internal DocuWare.Platform.ServerClient.OwnWorkflow Obj { get; } = obj;

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public List<IRequestDataDecision> TakenDecision
        {
            get => Obj.TakenDecision.Select(x => new RequestDataDecision(x) as IRequestDataDecision).ToList();
            set => Obj.TakenDecision = value.Select(x => ((RequestDataDecision)x).Obj).ToList();
        }

        public string Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }

        public int DocId
        {
            get => Obj.DocId;
            set => Obj.DocId = value;
        }

        public string FcGuid
        {
            get => Obj.FcGuid;
            set => Obj.FcGuid = value;
        }

        public DateTime CreateDate
        {
            get => Obj.CreateDate;
            set => Obj.CreateDate = value;
        }

        public string WorkflowName
        {
            get => Obj.WorkflowName;
            set => Obj.WorkflowName = value;
        }

        public string DocumentName
        {
            get => Obj.DocumentName;
            set => Obj.DocumentName = value;
        }

        public DocuWare.Platform.ServerClient.RequestExecutionStateEnum ExecutionState
        {
            get => Obj.ExecutionState;
            set => Obj.ExecutionState = value;
        }

        public string TakenDecisionName
        {
            get => Obj.TakenDecisionName;
            set => Obj.TakenDecisionName = value;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public IOwnWorkflow GetOwnWorkflowFromSelfRelation() => new OwnWorkflow(Obj.GetOwnWorkflowFromSelfRelation());

        public async Task<DeserializedHttpResponse<IOwnWorkflow>> GetOwnWorkflowFromSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.OwnWorkflow> result = await Obj.GetOwnWorkflowFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new OwnWorkflow(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IOwnWorkflow>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IOwnWorkflow>> GetOwnWorkflowFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.OwnWorkflow> result = await Obj.GetOwnWorkflowFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new OwnWorkflow(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IOwnWorkflow>(temp).ConfigureAwait(false);
        }

		public string DeleteSelfRelation() => Obj.DeleteSelfRelation();

		public async Task<DeserializedHttpResponse<string>> DeleteSelfRelationAsync() => await Obj.DeleteSelfRelationAsync();

		public async Task<DeserializedHttpResponse<string>> DeleteSelfRelationAsync(CancellationToken cancellationToken) => await Obj.DeleteSelfRelationAsync(cancellationToken);

        public IInstanceHistory GetInstanceHistoryFromHistoryRelation() => new InstanceHistory(Obj.GetInstanceHistoryFromHistoryRelation());

        public async Task<DeserializedHttpResponse<IInstanceHistory>> GetInstanceHistoryFromHistoryRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.InstanceHistory> result = await Obj.GetInstanceHistoryFromHistoryRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new InstanceHistory(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IInstanceHistory>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IInstanceHistory>> GetInstanceHistoryFromHistoryRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.InstanceHistory> result = await Obj.GetInstanceHistoryFromHistoryRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new InstanceHistory(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IInstanceHistory>(temp).ConfigureAwait(false);
        }
    }
}

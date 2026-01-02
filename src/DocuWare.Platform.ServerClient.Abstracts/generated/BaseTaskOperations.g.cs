using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BaseTaskOperations(SDK.BaseTaskOperations obj) : IBaseTaskOperations
    {
        internal SDK.BaseTaskOperations Obj { get; } = obj;

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public string SelfRelationLink => Obj.SelfRelationLink;

        public string MaintenanceSelfRelationLink => Obj.MaintenanceSelfRelationLink;

        public string ReassignedTaskRelationLink => Obj.ReassignedTaskRelationLink;

        public string HistoryRelationLink => Obj.HistoryRelationLink;

        public string StampSettingsRelationLink => Obj.StampSettingsRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public WorkflowTask GetWorkflowTaskFromSelfRelation() => new WorkflowTask(Obj.GetWorkflowTaskFromSelfRelation());

        public async Task<DeserializedHttpResponse<IWorkflowTask>> GetWorkflowTaskFromSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WorkflowTask> result = await Obj.GetWorkflowTaskFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WorkflowTask(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<WorkflowTask>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IWorkflowTask>> GetWorkflowTaskFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WorkflowTask> result = await Obj.GetWorkflowTaskFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WorkflowTask(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<WorkflowTask>(temp).ConfigureAwait(false);
        }

        public WorkflowTask GetWorkflowTaskFromMaintenanceSelfRelation() => new WorkflowTask(Obj.GetWorkflowTaskFromMaintenanceSelfRelation());

        public async Task<DeserializedHttpResponse<IWorkflowTask>> GetWorkflowTaskFromMaintenanceSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WorkflowTask> result = await Obj.GetWorkflowTaskFromMaintenanceSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WorkflowTask(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<WorkflowTask>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IWorkflowTask>> GetWorkflowTaskFromMaintenanceSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WorkflowTask> result = await Obj.GetWorkflowTaskFromMaintenanceSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WorkflowTask(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<WorkflowTask>(temp).ConfigureAwait(false);
        }

		public async string PostToReassignedTaskRelationForString(IReassignmentData dataToSend) => Obj.PostToReassignedTaskRelationForString(dataToSend);

        public async Task<DeserializedHttpResponse<string>> PostToReassignedTaskRelationForStringAsync(IReassignmentData dataToSend)
        {
            DeserializedHttpResponse<string> result = await Obj.PostToReassignedTaskRelationForStringAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<string>> PostToReassignedTaskRelationForStringAsync(CancellationToken cancellationToken, IReassignmentData dataToSend)
        {
            DeserializedHttpResponse<string> result = await Obj.PostToReassignedTaskRelationForStringAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public InstanceHistory GetInstanceHistoryFromHistoryRelation() => new InstanceHistory(Obj.GetInstanceHistoryFromHistoryRelation());

        public async Task<DeserializedHttpResponse<IInstanceHistory>> GetInstanceHistoryFromHistoryRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.InstanceHistory> result = await Obj.GetInstanceHistoryFromHistoryRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new InstanceHistory(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<InstanceHistory>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IInstanceHistory>> GetInstanceHistoryFromHistoryRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.InstanceHistory> result = await Obj.GetInstanceHistoryFromHistoryRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new InstanceHistory(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<InstanceHistory>(temp).ConfigureAwait(false);
        }

        public DecisionsStampSettings GetDecisionsStampSettingsFromStampSettingsRelation() => new DecisionsStampSettings(Obj.GetDecisionsStampSettingsFromStampSettingsRelation());

        public async Task<DeserializedHttpResponse<IDecisionsStampSettings>> GetDecisionsStampSettingsFromStampSettingsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DecisionsStampSettings> result = await Obj.GetDecisionsStampSettingsFromStampSettingsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DecisionsStampSettings(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DecisionsStampSettings>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDecisionsStampSettings>> GetDecisionsStampSettingsFromStampSettingsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DecisionsStampSettings> result = await Obj.GetDecisionsStampSettingsFromStampSettingsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DecisionsStampSettings(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DecisionsStampSettings>(temp).ConfigureAwait(false);
        }
    }
}

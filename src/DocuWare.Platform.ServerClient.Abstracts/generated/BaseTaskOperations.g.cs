using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BaseTaskOperations(DocuWare.Platform.ServerClient.BaseTaskOperations obj) : IBaseTaskOperations
    {
        internal DocuWare.Platform.ServerClient.BaseTaskOperations Obj { get; } = obj;

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public IWorkflowTask GetWorkflowTaskFromSelfRelation() => new WorkflowTask(Obj.GetWorkflowTaskFromSelfRelation());

        public async Task<DeserializedHttpResponse<IWorkflowTask>> GetWorkflowTaskFromSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WorkflowTask> result = await Obj.GetWorkflowTaskFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WorkflowTask(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflowTask>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IWorkflowTask>> GetWorkflowTaskFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WorkflowTask> result = await Obj.GetWorkflowTaskFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WorkflowTask(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflowTask>(temp).ConfigureAwait(false);
        }

        public IWorkflowTask GetWorkflowTaskFromMaintenanceSelfRelation() => new WorkflowTask(Obj.GetWorkflowTaskFromMaintenanceSelfRelation());

        public async Task<DeserializedHttpResponse<IWorkflowTask>> GetWorkflowTaskFromMaintenanceSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WorkflowTask> result = await Obj.GetWorkflowTaskFromMaintenanceSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WorkflowTask(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflowTask>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IWorkflowTask>> GetWorkflowTaskFromMaintenanceSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WorkflowTask> result = await Obj.GetWorkflowTaskFromMaintenanceSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WorkflowTask(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflowTask>(temp).ConfigureAwait(false);
        }

		public string PostToReassignedTaskRelationForString(IReassignmentData dataToSend) => Obj.PostToReassignedTaskRelationForString(((ReassignmentData)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<string>> PostToReassignedTaskRelationForStringAsync(IReassignmentData dataToSend) => await Obj.PostToReassignedTaskRelationForStringAsync(((ReassignmentData)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<string>> PostToReassignedTaskRelationForStringAsync(CancellationToken cancellationToken, IReassignmentData dataToSend) => await Obj.PostToReassignedTaskRelationForStringAsync(cancellationToken, ((ReassignmentData)dataToSend).Obj);

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

        public IDecisionsStampSettings GetDecisionsStampSettingsFromStampSettingsRelation() => new DecisionsStampSettings(Obj.GetDecisionsStampSettingsFromStampSettingsRelation());

        public async Task<DeserializedHttpResponse<IDecisionsStampSettings>> GetDecisionsStampSettingsFromStampSettingsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DecisionsStampSettings> result = await Obj.GetDecisionsStampSettingsFromStampSettingsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DecisionsStampSettings(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDecisionsStampSettings>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDecisionsStampSettings>> GetDecisionsStampSettingsFromStampSettingsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DecisionsStampSettings> result = await Obj.GetDecisionsStampSettingsFromStampSettingsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DecisionsStampSettings(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDecisionsStampSettings>(temp).ConfigureAwait(false);
        }
    }
}

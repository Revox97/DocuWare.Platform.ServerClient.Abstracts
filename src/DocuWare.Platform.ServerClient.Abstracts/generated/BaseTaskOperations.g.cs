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
        public IWorkflowTask GetWorkflowTaskFromSelfRelation() => new WorkflowTask(Obj.GetWorkflowTaskFromSelfRelation());

        public async Task<DeserializedHttpResponse<IWorkflowTask>> GetWorkflowTaskFromSelfRelationAsync()
        {
            DocuWare.Platform.ServerClient.IWorkflowTask result = await Obj.GetWorkflowTaskFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IWorkflowTask(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflowTask>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IWorkflowTask>> GetWorkflowTaskFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IWorkflowTask result = await Obj.GetWorkflowTaskFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IWorkflowTask(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflowTask>(temp).ConfigureAwait(false);
        }

        public IWorkflowTask GetWorkflowTaskFromMaintenanceSelfRelation() => new WorkflowTask(Obj.GetWorkflowTaskFromMaintenanceSelfRelation());

        public async Task<DeserializedHttpResponse<IWorkflowTask>> GetWorkflowTaskFromMaintenanceSelfRelationAsync()
        {
            DocuWare.Platform.ServerClient.IWorkflowTask result = await Obj.GetWorkflowTaskFromMaintenanceSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IWorkflowTask(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflowTask>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IWorkflowTask>> GetWorkflowTaskFromMaintenanceSelfRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IWorkflowTask result = await Obj.GetWorkflowTaskFromMaintenanceSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IWorkflowTask(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflowTask>(temp).ConfigureAwait(false);
        }

		public async string PostToReassignedTaskRelationForString(IReassignmentData dataToSend) => Obj.PostToReassignedTaskRelationForString(dataToSend);
        public async Task<DeserializedHttpResponse<string>> PostToReassignedTaskRelationForStringAsync(IReassignmentData dataToSend)
        {
            DocuWare.Platform.ServerClient.string result = await Obj.PostToReassignedTaskRelationForStringAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<string>> PostToReassignedTaskRelationForStringAsync(CancellationToken cancellationToken, IReassignmentData dataToSend)
        {
            DocuWare.Platform.ServerClient.string result = await Obj.PostToReassignedTaskRelationForStringAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public IInstanceHistory GetInstanceHistoryFromHistoryRelation() => new InstanceHistory(Obj.GetInstanceHistoryFromHistoryRelation());

        public async Task<DeserializedHttpResponse<IInstanceHistory>> GetInstanceHistoryFromHistoryRelationAsync()
        {
            DocuWare.Platform.ServerClient.IInstanceHistory result = await Obj.GetInstanceHistoryFromHistoryRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IInstanceHistory(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IInstanceHistory>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IInstanceHistory>> GetInstanceHistoryFromHistoryRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IInstanceHistory result = await Obj.GetInstanceHistoryFromHistoryRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IInstanceHistory(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IInstanceHistory>(temp).ConfigureAwait(false);
        }

        public IDecisionsStampSettings GetDecisionsStampSettingsFromStampSettingsRelation() => new DecisionsStampSettings(Obj.GetDecisionsStampSettingsFromStampSettingsRelation());

        public async Task<DeserializedHttpResponse<IDecisionsStampSettings>> GetDecisionsStampSettingsFromStampSettingsRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDecisionsStampSettings result = await Obj.GetDecisionsStampSettingsFromStampSettingsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDecisionsStampSettings(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDecisionsStampSettings>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDecisionsStampSettings>> GetDecisionsStampSettingsFromStampSettingsRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDecisionsStampSettings result = await Obj.GetDecisionsStampSettingsFromStampSettingsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDecisionsStampSettings(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDecisionsStampSettings>(temp).ConfigureAwait(false);
        }

    }
}

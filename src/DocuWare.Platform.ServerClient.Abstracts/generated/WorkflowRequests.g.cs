using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WorkflowRequests(SDK.WorkflowRequests obj) : IWorkflowRequests
    {
        internal SDK.WorkflowRequests Obj { get; } = obj;

		public Link[] Links
		{
			get => Obj.Links;
			set => Obj.Links = value;
		}

		public string MyTasksRelationLink => Obj.MyTasksRelationLink;

		public string MyTasksCountRelationLink => Obj.MyTasksCountRelationLink;

		public string CreatedWorkflowsRelationLink => Obj.CreatedWorkflowsRelationLink;

		public string CreatedWorkflowsCountRelationLink => Obj.CreatedWorkflowsCountRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
        public IRequestTasks GetRequestTasksFromMyTasksRelation() => new RequestTasks(Obj.GetRequestTasksFromMyTasksRelation());

        public async Task<DeserializedHttpResponse<IRequestTasks>> GetRequestTasksFromMyTasksRelationAsync()
        {
            DocuWare.Platform.ServerClient.IRequestTasks result = await Obj.GetRequestTasksFromMyTasksRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IRequestTasks(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IRequestTasks>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IRequestTasks>> GetRequestTasksFromMyTasksRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IRequestTasks result = await Obj.GetRequestTasksFromMyTasksRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IRequestTasks(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IRequestTasks>(temp).ConfigureAwait(false);
        }

        public IRequestTasks PostToMyTasksRelationForRequestTasks(ITasksQuery dataToSend) => new RequestTasks(Obj.PostToMyTasksRelationForRequestTasks(dataToSend));

        public async Task<DeserializedHttpResponse<IRequestTasks>> PostToMyTasksRelationForRequestTasksAsync(ITasksQuery dataToSend)
        {
            DocuWare.Platform.ServerClient.IRequestTasks result = await Obj.PostToMyTasksRelationForRequestTasksAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IRequestTasks(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IRequestTasks>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IRequestTasks>> PostToMyTasksRelationForRequestTasksAsync(CancellationToken cancellationToken, ITasksQuery dataToSend)
        {
            DocuWare.Platform.ServerClient.IRequestTasks result = await Obj.PostToMyTasksRelationForRequestTasksAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IRequestTasks(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IRequestTasks>(temp).ConfigureAwait(false);
        }

        public IWorkflowTasksCount GetWorkflowTasksCountFromMyTasksCountRelation() => new WorkflowTasksCount(Obj.GetWorkflowTasksCountFromMyTasksCountRelation());

        public async Task<DeserializedHttpResponse<IWorkflowTasksCount>> GetWorkflowTasksCountFromMyTasksCountRelationAsync()
        {
            DocuWare.Platform.ServerClient.IWorkflowTasksCount result = await Obj.GetWorkflowTasksCountFromMyTasksCountRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IWorkflowTasksCount(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflowTasksCount>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IWorkflowTasksCount>> GetWorkflowTasksCountFromMyTasksCountRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IWorkflowTasksCount result = await Obj.GetWorkflowTasksCountFromMyTasksCountRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IWorkflowTasksCount(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflowTasksCount>(temp).ConfigureAwait(false);
        }

        public IOwnWorkflows GetOwnWorkflowsFromCreatedWorkflowsRelation() => new OwnWorkflows(Obj.GetOwnWorkflowsFromCreatedWorkflowsRelation());

        public async Task<DeserializedHttpResponse<IOwnWorkflows>> GetOwnWorkflowsFromCreatedWorkflowsRelationAsync()
        {
            DocuWare.Platform.ServerClient.IOwnWorkflows result = await Obj.GetOwnWorkflowsFromCreatedWorkflowsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IOwnWorkflows(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IOwnWorkflows>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IOwnWorkflows>> GetOwnWorkflowsFromCreatedWorkflowsRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IOwnWorkflows result = await Obj.GetOwnWorkflowsFromCreatedWorkflowsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IOwnWorkflows(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IOwnWorkflows>(temp).ConfigureAwait(false);
        }

        public IOwnWorkflows PostToCreatedWorkflowsRelationForOwnWorkflows(ITasksQuery dataToSend) => new OwnWorkflows(Obj.PostToCreatedWorkflowsRelationForOwnWorkflows(dataToSend));

        public async Task<DeserializedHttpResponse<IOwnWorkflows>> PostToCreatedWorkflowsRelationForOwnWorkflowsAsync(ITasksQuery dataToSend)
        {
            DocuWare.Platform.ServerClient.IOwnWorkflows result = await Obj.PostToCreatedWorkflowsRelationForOwnWorkflowsAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IOwnWorkflows(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IOwnWorkflows>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IOwnWorkflows>> PostToCreatedWorkflowsRelationForOwnWorkflowsAsync(CancellationToken cancellationToken, ITasksQuery dataToSend)
        {
            DocuWare.Platform.ServerClient.IOwnWorkflows result = await Obj.PostToCreatedWorkflowsRelationForOwnWorkflowsAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IOwnWorkflows(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IOwnWorkflows>(temp).ConfigureAwait(false);
        }

        public IWorkflowTasksCount GetWorkflowTasksCountFromCreatedWorkflowsCountRelation() => new WorkflowTasksCount(Obj.GetWorkflowTasksCountFromCreatedWorkflowsCountRelation());

        public async Task<DeserializedHttpResponse<IWorkflowTasksCount>> GetWorkflowTasksCountFromCreatedWorkflowsCountRelationAsync()
        {
            DocuWare.Platform.ServerClient.IWorkflowTasksCount result = await Obj.GetWorkflowTasksCountFromCreatedWorkflowsCountRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IWorkflowTasksCount(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflowTasksCount>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IWorkflowTasksCount>> GetWorkflowTasksCountFromCreatedWorkflowsCountRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IWorkflowTasksCount result = await Obj.GetWorkflowTasksCountFromCreatedWorkflowsCountRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IWorkflowTasksCount(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflowTasksCount>(temp).ConfigureAwait(false);
        }

    }
}

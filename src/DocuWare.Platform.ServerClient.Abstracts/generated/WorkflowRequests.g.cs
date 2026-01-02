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

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public IRequestTasks GetRequestTasksFromMyTasksRelation() => new RequestTasks(Obj.GetRequestTasksFromMyTasksRelation());

        public async Task<DeserializedHttpResponse<IRequestTasks>> GetRequestTasksFromMyTasksRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.RequestTasks> result = await Obj.GetRequestTasksFromMyTasksRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new RequestTasks(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IRequestTasks>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IRequestTasks>> GetRequestTasksFromMyTasksRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.RequestTasks> result = await Obj.GetRequestTasksFromMyTasksRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new RequestTasks(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IRequestTasks>(temp).ConfigureAwait(false);
        }

        public IRequestTasks PostToMyTasksRelationForRequestTasks(ITasksQuery dataToSend) => new RequestTasks(Obj.PostToMyTasksRelationForRequestTasks(((TasksQuery)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IRequestTasks>> PostToMyTasksRelationForRequestTasksAsync(ITasksQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.RequestTasks> result = await Obj.PostToMyTasksRelationForRequestTasksAsync(((TasksQuery)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new RequestTasks(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IRequestTasks>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IRequestTasks>> PostToMyTasksRelationForRequestTasksAsync(CancellationToken cancellationToken, ITasksQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.RequestTasks> result = await Obj.PostToMyTasksRelationForRequestTasksAsync(cancellationToken, ((TasksQuery)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new RequestTasks(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IRequestTasks>(temp).ConfigureAwait(false);
        }

        public IWorkflowTasksCount GetWorkflowTasksCountFromMyTasksCountRelation() => new WorkflowTasksCount(Obj.GetWorkflowTasksCountFromMyTasksCountRelation());

        public async Task<DeserializedHttpResponse<IWorkflowTasksCount>> GetWorkflowTasksCountFromMyTasksCountRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WorkflowTasksCount> result = await Obj.GetWorkflowTasksCountFromMyTasksCountRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WorkflowTasksCount(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflowTasksCount>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IWorkflowTasksCount>> GetWorkflowTasksCountFromMyTasksCountRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WorkflowTasksCount> result = await Obj.GetWorkflowTasksCountFromMyTasksCountRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WorkflowTasksCount(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflowTasksCount>(temp).ConfigureAwait(false);
        }

        public IOwnWorkflows GetOwnWorkflowsFromCreatedWorkflowsRelation() => new OwnWorkflows(Obj.GetOwnWorkflowsFromCreatedWorkflowsRelation());

        public async Task<DeserializedHttpResponse<IOwnWorkflows>> GetOwnWorkflowsFromCreatedWorkflowsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.OwnWorkflows> result = await Obj.GetOwnWorkflowsFromCreatedWorkflowsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new OwnWorkflows(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IOwnWorkflows>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IOwnWorkflows>> GetOwnWorkflowsFromCreatedWorkflowsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.OwnWorkflows> result = await Obj.GetOwnWorkflowsFromCreatedWorkflowsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new OwnWorkflows(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IOwnWorkflows>(temp).ConfigureAwait(false);
        }

        public IOwnWorkflows PostToCreatedWorkflowsRelationForOwnWorkflows(ITasksQuery dataToSend) => new OwnWorkflows(Obj.PostToCreatedWorkflowsRelationForOwnWorkflows(((TasksQuery)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IOwnWorkflows>> PostToCreatedWorkflowsRelationForOwnWorkflowsAsync(ITasksQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.OwnWorkflows> result = await Obj.PostToCreatedWorkflowsRelationForOwnWorkflowsAsync(((TasksQuery)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new OwnWorkflows(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IOwnWorkflows>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IOwnWorkflows>> PostToCreatedWorkflowsRelationForOwnWorkflowsAsync(CancellationToken cancellationToken, ITasksQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.OwnWorkflows> result = await Obj.PostToCreatedWorkflowsRelationForOwnWorkflowsAsync(cancellationToken, ((TasksQuery)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new OwnWorkflows(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IOwnWorkflows>(temp).ConfigureAwait(false);
        }

        public IWorkflowTasksCount GetWorkflowTasksCountFromCreatedWorkflowsCountRelation() => new WorkflowTasksCount(Obj.GetWorkflowTasksCountFromCreatedWorkflowsCountRelation());

        public async Task<DeserializedHttpResponse<IWorkflowTasksCount>> GetWorkflowTasksCountFromCreatedWorkflowsCountRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WorkflowTasksCount> result = await Obj.GetWorkflowTasksCountFromCreatedWorkflowsCountRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WorkflowTasksCount(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflowTasksCount>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IWorkflowTasksCount>> GetWorkflowTasksCountFromCreatedWorkflowsCountRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WorkflowTasksCount> result = await Obj.GetWorkflowTasksCountFromCreatedWorkflowsCountRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WorkflowTasksCount(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflowTasksCount>(temp).ConfigureAwait(false);
        }
    }
}

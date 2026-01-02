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

        public RequestTasks GetRequestTasksFromMyTasksRelation() => new RequestTasks(Obj.GetRequestTasksFromMyTasksRelation());

        public async Task<DeserializedHttpResponse<IRequestTasks>> GetRequestTasksFromMyTasksRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.RequestTasks> result = await Obj.GetRequestTasksFromMyTasksRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new RequestTasks(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<RequestTasks>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IRequestTasks>> GetRequestTasksFromMyTasksRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.RequestTasks> result = await Obj.GetRequestTasksFromMyTasksRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new RequestTasks(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<RequestTasks>(temp).ConfigureAwait(false);
        }

        public RequestTasks PostToMyTasksRelationForRequestTasks(ITasksQuery dataToSend) => new RequestTasks(Obj.PostToMyTasksRelationForRequestTasks(dataToSend));

        public async Task<DeserializedHttpResponse<IRequestTasks>> PostToMyTasksRelationForRequestTasksAsync(ITasksQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.RequestTasks> result = await Obj.PostToMyTasksRelationForRequestTasksAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new RequestTasks(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<RequestTasks>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IRequestTasks>> PostToMyTasksRelationForRequestTasksAsync(CancellationToken cancellationToken, ITasksQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.RequestTasks> result = await Obj.PostToMyTasksRelationForRequestTasksAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new RequestTasks(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<RequestTasks>(temp).ConfigureAwait(false);
        }

        public WorkflowTasksCount GetWorkflowTasksCountFromMyTasksCountRelation() => new WorkflowTasksCount(Obj.GetWorkflowTasksCountFromMyTasksCountRelation());

        public async Task<DeserializedHttpResponse<IWorkflowTasksCount>> GetWorkflowTasksCountFromMyTasksCountRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WorkflowTasksCount> result = await Obj.GetWorkflowTasksCountFromMyTasksCountRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WorkflowTasksCount(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<WorkflowTasksCount>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IWorkflowTasksCount>> GetWorkflowTasksCountFromMyTasksCountRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WorkflowTasksCount> result = await Obj.GetWorkflowTasksCountFromMyTasksCountRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WorkflowTasksCount(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<WorkflowTasksCount>(temp).ConfigureAwait(false);
        }

        public OwnWorkflows GetOwnWorkflowsFromCreatedWorkflowsRelation() => new OwnWorkflows(Obj.GetOwnWorkflowsFromCreatedWorkflowsRelation());

        public async Task<DeserializedHttpResponse<IOwnWorkflows>> GetOwnWorkflowsFromCreatedWorkflowsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.OwnWorkflows> result = await Obj.GetOwnWorkflowsFromCreatedWorkflowsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new OwnWorkflows(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<OwnWorkflows>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IOwnWorkflows>> GetOwnWorkflowsFromCreatedWorkflowsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.OwnWorkflows> result = await Obj.GetOwnWorkflowsFromCreatedWorkflowsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new OwnWorkflows(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<OwnWorkflows>(temp).ConfigureAwait(false);
        }

        public OwnWorkflows PostToCreatedWorkflowsRelationForOwnWorkflows(ITasksQuery dataToSend) => new OwnWorkflows(Obj.PostToCreatedWorkflowsRelationForOwnWorkflows(dataToSend));

        public async Task<DeserializedHttpResponse<IOwnWorkflows>> PostToCreatedWorkflowsRelationForOwnWorkflowsAsync(ITasksQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.OwnWorkflows> result = await Obj.PostToCreatedWorkflowsRelationForOwnWorkflowsAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new OwnWorkflows(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<OwnWorkflows>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IOwnWorkflows>> PostToCreatedWorkflowsRelationForOwnWorkflowsAsync(CancellationToken cancellationToken, ITasksQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.OwnWorkflows> result = await Obj.PostToCreatedWorkflowsRelationForOwnWorkflowsAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new OwnWorkflows(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<OwnWorkflows>(temp).ConfigureAwait(false);
        }

        public WorkflowTasksCount GetWorkflowTasksCountFromCreatedWorkflowsCountRelation() => new WorkflowTasksCount(Obj.GetWorkflowTasksCountFromCreatedWorkflowsCountRelation());

        public async Task<DeserializedHttpResponse<IWorkflowTasksCount>> GetWorkflowTasksCountFromCreatedWorkflowsCountRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WorkflowTasksCount> result = await Obj.GetWorkflowTasksCountFromCreatedWorkflowsCountRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WorkflowTasksCount(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<WorkflowTasksCount>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IWorkflowTasksCount>> GetWorkflowTasksCountFromCreatedWorkflowsCountRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WorkflowTasksCount> result = await Obj.GetWorkflowTasksCountFromCreatedWorkflowsCountRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WorkflowTasksCount(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<WorkflowTasksCount>(temp).ConfigureAwait(false);
        }
    }
}

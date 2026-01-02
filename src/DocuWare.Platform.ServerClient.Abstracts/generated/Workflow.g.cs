using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Workflow(SDK.Workflow obj) : IWorkflow
    {
        internal SDK.Workflow Obj { get; } = obj;

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public string Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }

        public string Name
        {
            get => Obj.Name;
            set => Obj.Name = value;
        }

        public int TaskCount
        {
            get => Obj.TaskCount;
            set => Obj.TaskCount = value;
        }

        public string FileCabinetId
        {
            get => Obj.FileCabinetId;
            set => Obj.FileCabinetId = value;
        }

        public DateTime TimeStamp
        {
            get => Obj.TimeStamp;
            set => Obj.TimeStamp = value;
        }

        public string ResultListId
        {
            get => Obj.ResultListId;
            set => Obj.ResultListId = value;
        }

        public bool HasDocumentFields
        {
            get => Obj.HasDocumentFields;
            set => Obj.HasDocumentFields = value;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public IWorkflow GetWorkflowFromSelfRelation() => new Workflow(Obj.GetWorkflowFromSelfRelation());

        public async Task<DeserializedHttpResponse<IWorkflow>> GetWorkflowFromSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Workflow> result = await Obj.GetWorkflowFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Workflow(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflow>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IWorkflow>> GetWorkflowFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Workflow> result = await Obj.GetWorkflowFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Workflow(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflow>(temp).ConfigureAwait(false);
        }

        public IWorkflowTasks GetWorkflowTasksFromTasksRelation() => new WorkflowTasks(Obj.GetWorkflowTasksFromTasksRelation());

        public async Task<DeserializedHttpResponse<IWorkflowTasks>> GetWorkflowTasksFromTasksRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WorkflowTasks> result = await Obj.GetWorkflowTasksFromTasksRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WorkflowTasks(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflowTasks>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IWorkflowTasks>> GetWorkflowTasksFromTasksRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WorkflowTasks> result = await Obj.GetWorkflowTasksFromTasksRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WorkflowTasks(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflowTasks>(temp).ConfigureAwait(false);
        }

        public IWorkflowTasks PostToTasksRelationForWorkflowTasks(ITasksQuery dataToSend) => new WorkflowTasks(Obj.PostToTasksRelationForWorkflowTasks(((TasksQuery)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IWorkflowTasks>> PostToTasksRelationForWorkflowTasksAsync(ITasksQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WorkflowTasks> result = await Obj.PostToTasksRelationForWorkflowTasksAsync(((TasksQuery)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WorkflowTasks(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflowTasks>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IWorkflowTasks>> PostToTasksRelationForWorkflowTasksAsync(CancellationToken cancellationToken, ITasksQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WorkflowTasks> result = await Obj.PostToTasksRelationForWorkflowTasksAsync(cancellationToken, ((TasksQuery)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WorkflowTasks(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflowTasks>(temp).ConfigureAwait(false);
        }

        public IWorkflowTasksCount GetWorkflowTasksCountFromCountRelation() => new WorkflowTasksCount(Obj.GetWorkflowTasksCountFromCountRelation());

        public async Task<DeserializedHttpResponse<IWorkflowTasksCount>> GetWorkflowTasksCountFromCountRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WorkflowTasksCount> result = await Obj.GetWorkflowTasksCountFromCountRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WorkflowTasksCount(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflowTasksCount>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IWorkflowTasksCount>> GetWorkflowTasksCountFromCountRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WorkflowTasksCount> result = await Obj.GetWorkflowTasksCountFromCountRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WorkflowTasksCount(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflowTasksCount>(temp).ConfigureAwait(false);
        }
    }
}

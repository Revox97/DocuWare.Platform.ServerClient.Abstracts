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

        public IColumnsDefinition ColumnDefinition
        {
            get => new ColumnsDefinition(Obj.ColumnDefinition);
            set => Obj.ColumnDefinition = ((ColumnsDefinition)value).Obj;
        }

        public IWorkflowBehaviorOptions WorkflowBehaviorOptions
        {
            get => new WorkflowBehaviorOptions(Obj.WorkflowBehaviorOptions);
            set => Obj.WorkflowBehaviorOptions = ((WorkflowBehaviorOptions)value).Obj;
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

        public string SelfRelationLink => Obj.SelfRelationLink;

        public string TasksRelationLink => Obj.TasksRelationLink;

        public string CountRelationLink => Obj.CountRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public IWorkflow GetWorkflowFromSelfRelation() => new Workflow(Obj.GetWorkflowFromSelfRelation());

        public async Task<DeserializedHttpResponse<IWorkflow>> GetWorkflowFromSelfRelationAsync()
        {
            DocuWare.Platform.ServerClient.IWorkflow result = await Obj.GetWorkflowFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IWorkflow(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflow>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IWorkflow>> GetWorkflowFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IWorkflow result = await Obj.GetWorkflowFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IWorkflow(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflow>(temp).ConfigureAwait(false);
        }

        public IWorkflowTasks GetWorkflowTasksFromTasksRelation() => new WorkflowTasks(Obj.GetWorkflowTasksFromTasksRelation());

        public async Task<DeserializedHttpResponse<IWorkflowTasks>> GetWorkflowTasksFromTasksRelationAsync()
        {
            DocuWare.Platform.ServerClient.IWorkflowTasks result = await Obj.GetWorkflowTasksFromTasksRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IWorkflowTasks(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflowTasks>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IWorkflowTasks>> GetWorkflowTasksFromTasksRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IWorkflowTasks result = await Obj.GetWorkflowTasksFromTasksRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IWorkflowTasks(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflowTasks>(temp).ConfigureAwait(false);
        }

        public IWorkflowTasks PostToTasksRelationForWorkflowTasks(ITasksQuery dataToSend) => new WorkflowTasks(Obj.PostToTasksRelationForWorkflowTasks(dataToSend));

        public async Task<DeserializedHttpResponse<IWorkflowTasks>> PostToTasksRelationForWorkflowTasksAsync(ITasksQuery dataToSend)
        {
            DocuWare.Platform.ServerClient.IWorkflowTasks result = await Obj.PostToTasksRelationForWorkflowTasksAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IWorkflowTasks(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflowTasks>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IWorkflowTasks>> PostToTasksRelationForWorkflowTasksAsync(CancellationToken cancellationToken, ITasksQuery dataToSend)
        {
            DocuWare.Platform.ServerClient.IWorkflowTasks result = await Obj.PostToTasksRelationForWorkflowTasksAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IWorkflowTasks(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflowTasks>(temp).ConfigureAwait(false);
        }

        public IWorkflowTasksCount GetWorkflowTasksCountFromCountRelation() => new WorkflowTasksCount(Obj.GetWorkflowTasksCountFromCountRelation());

        public async Task<DeserializedHttpResponse<IWorkflowTasksCount>> GetWorkflowTasksCountFromCountRelationAsync()
        {
            DocuWare.Platform.ServerClient.IWorkflowTasksCount result = await Obj.GetWorkflowTasksCountFromCountRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IWorkflowTasksCount(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflowTasksCount>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IWorkflowTasksCount>> GetWorkflowTasksCountFromCountRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IWorkflowTasksCount result = await Obj.GetWorkflowTasksCountFromCountRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IWorkflowTasksCount(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflowTasksCount>(temp).ConfigureAwait(false);
        }
    }
}

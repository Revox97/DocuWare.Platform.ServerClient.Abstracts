using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WorkflowTasks(SDK.WorkflowTasks obj) : IWorkflowTasks
    {
        internal SDK.WorkflowTasks Obj { get; } = obj;

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public List<IWorkflowTask> Task
        {
            get => Obj.Task.Select(x => new WorkflowTask(x) as IWorkflowTask).ToList();
            set => Obj.Task = value.Select(x => ((WorkflowTask)x).Obj).ToList();
        }

        public int Count
        {
            get => Obj.Count;
            set => Obj.Count = value;
        }

        public DateTime TimeStamp
        {
            get => Obj.TimeStamp;
            set => Obj.TimeStamp = value;
        }

        public bool HasDocumentFields
        {
            get => Obj.HasDocumentFields;
            set => Obj.HasDocumentFields = value;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public IWorkflowTasks GetWorkflowTasksFromNextRelation() => new WorkflowTasks(Obj.GetWorkflowTasksFromNextRelation());

        public async Task<DeserializedHttpResponse<IWorkflowTasks>> GetWorkflowTasksFromNextRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WorkflowTasks> result = await Obj.GetWorkflowTasksFromNextRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WorkflowTasks(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflowTasks>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IWorkflowTasks>> GetWorkflowTasksFromNextRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WorkflowTasks> result = await Obj.GetWorkflowTasksFromNextRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WorkflowTasks(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflowTasks>(temp).ConfigureAwait(false);
        }

        public IWorkflowTasks GetWorkflowTasksFromPrevRelation() => new WorkflowTasks(Obj.GetWorkflowTasksFromPrevRelation());

        public async Task<DeserializedHttpResponse<IWorkflowTasks>> GetWorkflowTasksFromPrevRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WorkflowTasks> result = await Obj.GetWorkflowTasksFromPrevRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WorkflowTasks(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflowTasks>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IWorkflowTasks>> GetWorkflowTasksFromPrevRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WorkflowTasks> result = await Obj.GetWorkflowTasksFromPrevRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WorkflowTasks(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflowTasks>(temp).ConfigureAwait(false);
        }

        public IWorkflowTasks GetWorkflowTasksFromSelfRelation() => new WorkflowTasks(Obj.GetWorkflowTasksFromSelfRelation());

        public async Task<DeserializedHttpResponse<IWorkflowTasks>> GetWorkflowTasksFromSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WorkflowTasks> result = await Obj.GetWorkflowTasksFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WorkflowTasks(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflowTasks>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IWorkflowTasks>> GetWorkflowTasksFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WorkflowTasks> result = await Obj.GetWorkflowTasksFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WorkflowTasks(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflowTasks>(temp).ConfigureAwait(false);
        }

        public IWorkflowTasks GetWorkflowTasksFromFirstRelation() => new WorkflowTasks(Obj.GetWorkflowTasksFromFirstRelation());

        public async Task<DeserializedHttpResponse<IWorkflowTasks>> GetWorkflowTasksFromFirstRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WorkflowTasks> result = await Obj.GetWorkflowTasksFromFirstRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WorkflowTasks(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflowTasks>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IWorkflowTasks>> GetWorkflowTasksFromFirstRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WorkflowTasks> result = await Obj.GetWorkflowTasksFromFirstRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WorkflowTasks(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflowTasks>(temp).ConfigureAwait(false);
        }
    }
}

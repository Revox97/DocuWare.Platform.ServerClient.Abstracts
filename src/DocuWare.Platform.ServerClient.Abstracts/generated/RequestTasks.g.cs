using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class RequestTasks(SDK.RequestTasks obj) : IRequestTasks
    {
        internal SDK.RequestTasks Obj { get; } = obj;

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public List<IRequestTask> Task
        {
            get => Obj.Task.Select(x => new RequestTask(x) as IRequestTask).ToList();
            set => Obj.Task = value.Select(x => ((RequestTask)x).Obj).ToList();
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

        public string NextRelationLink => Obj.NextRelationLink;

        public string PrevRelationLink => Obj.PrevRelationLink;

        public string SelfRelationLink => Obj.SelfRelationLink;

        public string FirstRelationLink => Obj.FirstRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public RequestTasks GetRequestTasksFromNextRelation() => new RequestTasks(Obj.GetRequestTasksFromNextRelation());

        public async Task<DeserializedHttpResponse<IRequestTasks>> GetRequestTasksFromNextRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.RequestTasks> result = await Obj.GetRequestTasksFromNextRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new RequestTasks(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<RequestTasks>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IRequestTasks>> GetRequestTasksFromNextRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.RequestTasks> result = await Obj.GetRequestTasksFromNextRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new RequestTasks(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<RequestTasks>(temp).ConfigureAwait(false);
        }

        public RequestTasks GetRequestTasksFromPrevRelation() => new RequestTasks(Obj.GetRequestTasksFromPrevRelation());

        public async Task<DeserializedHttpResponse<IRequestTasks>> GetRequestTasksFromPrevRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.RequestTasks> result = await Obj.GetRequestTasksFromPrevRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new RequestTasks(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<RequestTasks>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IRequestTasks>> GetRequestTasksFromPrevRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.RequestTasks> result = await Obj.GetRequestTasksFromPrevRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new RequestTasks(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<RequestTasks>(temp).ConfigureAwait(false);
        }

        public RequestTasks GetRequestTasksFromSelfRelation() => new RequestTasks(Obj.GetRequestTasksFromSelfRelation());

        public async Task<DeserializedHttpResponse<IRequestTasks>> GetRequestTasksFromSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.RequestTasks> result = await Obj.GetRequestTasksFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new RequestTasks(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<RequestTasks>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IRequestTasks>> GetRequestTasksFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.RequestTasks> result = await Obj.GetRequestTasksFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new RequestTasks(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<RequestTasks>(temp).ConfigureAwait(false);
        }

        public RequestTasks GetRequestTasksFromFirstRelation() => new RequestTasks(Obj.GetRequestTasksFromFirstRelation());

        public async Task<DeserializedHttpResponse<IRequestTasks>> GetRequestTasksFromFirstRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.RequestTasks> result = await Obj.GetRequestTasksFromFirstRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new RequestTasks(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<RequestTasks>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IRequestTasks>> GetRequestTasksFromFirstRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.RequestTasks> result = await Obj.GetRequestTasksFromFirstRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new RequestTasks(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<RequestTasks>(temp).ConfigureAwait(false);
        }
    }
}

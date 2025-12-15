using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class OwnWorkflows(SDK.OwnWorkflows obj) : IOwnWorkflows
    {
        internal SDK.OwnWorkflows Obj { get; } = obj;

		public Link[] Links
		{
			get => Obj.Links;
			set => Obj.Links = value;
		}

		public List<IOwnWorkflow> Workflow
		{
			get => Obj.Workflow.Select(x => new OwnWorkflow(x) as IOwnWorkflow).ToList();
			set => Obj.Workflow = value.Select(x => ((OwnWorkflow)x).Obj).ToList();
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
        public IOwnWorkflows GetOwnWorkflowsFromNextRelation() => new OwnWorkflows(Obj.GetOwnWorkflowsFromNextRelation());

        public async Task<DeserializedHttpResponse<IOwnWorkflows>> GetOwnWorkflowsFromNextRelationAsync()
        {
            DocuWare.Platform.ServerClient.IOwnWorkflows result = await Obj.GetOwnWorkflowsFromNextRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IOwnWorkflows(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IOwnWorkflows>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IOwnWorkflows>> GetOwnWorkflowsFromNextRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IOwnWorkflows result = await Obj.GetOwnWorkflowsFromNextRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IOwnWorkflows(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IOwnWorkflows>(temp).ConfigureAwait(false);
        }

        public IOwnWorkflows GetOwnWorkflowsFromPrevRelation() => new OwnWorkflows(Obj.GetOwnWorkflowsFromPrevRelation());

        public async Task<DeserializedHttpResponse<IOwnWorkflows>> GetOwnWorkflowsFromPrevRelationAsync()
        {
            DocuWare.Platform.ServerClient.IOwnWorkflows result = await Obj.GetOwnWorkflowsFromPrevRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IOwnWorkflows(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IOwnWorkflows>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IOwnWorkflows>> GetOwnWorkflowsFromPrevRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IOwnWorkflows result = await Obj.GetOwnWorkflowsFromPrevRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IOwnWorkflows(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IOwnWorkflows>(temp).ConfigureAwait(false);
        }

        public IOwnWorkflows GetOwnWorkflowsFromSelfRelation() => new OwnWorkflows(Obj.GetOwnWorkflowsFromSelfRelation());

        public async Task<DeserializedHttpResponse<IOwnWorkflows>> GetOwnWorkflowsFromSelfRelationAsync()
        {
            DocuWare.Platform.ServerClient.IOwnWorkflows result = await Obj.GetOwnWorkflowsFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IOwnWorkflows(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IOwnWorkflows>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IOwnWorkflows>> GetOwnWorkflowsFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IOwnWorkflows result = await Obj.GetOwnWorkflowsFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IOwnWorkflows(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IOwnWorkflows>(temp).ConfigureAwait(false);
        }

        public IOwnWorkflows GetOwnWorkflowsFromFirstRelation() => new OwnWorkflows(Obj.GetOwnWorkflowsFromFirstRelation());

        public async Task<DeserializedHttpResponse<IOwnWorkflows>> GetOwnWorkflowsFromFirstRelationAsync()
        {
            DocuWare.Platform.ServerClient.IOwnWorkflows result = await Obj.GetOwnWorkflowsFromFirstRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IOwnWorkflows(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IOwnWorkflows>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IOwnWorkflows>> GetOwnWorkflowsFromFirstRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IOwnWorkflows result = await Obj.GetOwnWorkflowsFromFirstRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IOwnWorkflows(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IOwnWorkflows>(temp).ConfigureAwait(false);
        }

    }
}

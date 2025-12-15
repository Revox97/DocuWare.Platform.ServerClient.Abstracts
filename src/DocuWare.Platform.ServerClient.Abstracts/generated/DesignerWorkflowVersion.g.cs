using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DesignerWorkflowVersion(SDK.DesignerWorkflowVersion obj) : IDesignerWorkflowVersion
    {
        internal SDK.DesignerWorkflowVersion Obj { get; } = obj;

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

		public int InstanceCount
		{
			get => Obj.InstanceCount;
			set => Obj.InstanceCount = value;
		}

		public string SelfRelationLink => Obj.SelfRelationLink;

		public string InstancesRelationLink => Obj.InstancesRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
        public IDesignerWorkflowVersion GetDesignerWorkflowVersionFromSelfRelation() => new DesignerWorkflowVersion(Obj.GetDesignerWorkflowVersionFromSelfRelation());

        public async Task<DeserializedHttpResponse<IDesignerWorkflowVersion>> GetDesignerWorkflowVersionFromSelfRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDesignerWorkflowVersion result = await Obj.GetDesignerWorkflowVersionFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDesignerWorkflowVersion(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDesignerWorkflowVersion>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDesignerWorkflowVersion>> GetDesignerWorkflowVersionFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDesignerWorkflowVersion result = await Obj.GetDesignerWorkflowVersionFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDesignerWorkflowVersion(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDesignerWorkflowVersion>(temp).ConfigureAwait(false);
        }

        public IDesignerInstances GetDesignerInstancesFromInstancesRelation() => new DesignerInstances(Obj.GetDesignerInstancesFromInstancesRelation());

        public async Task<DeserializedHttpResponse<IDesignerInstances>> GetDesignerInstancesFromInstancesRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDesignerInstances result = await Obj.GetDesignerInstancesFromInstancesRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDesignerInstances(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDesignerInstances>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDesignerInstances>> GetDesignerInstancesFromInstancesRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDesignerInstances result = await Obj.GetDesignerInstancesFromInstancesRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDesignerInstances(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDesignerInstances>(temp).ConfigureAwait(false);
        }

    }
}

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

        public DesignerWorkflowVersion GetDesignerWorkflowVersionFromSelfRelation() => new DesignerWorkflowVersion(Obj.GetDesignerWorkflowVersionFromSelfRelation());

        public async Task<DeserializedHttpResponse<IDesignerWorkflowVersion>> GetDesignerWorkflowVersionFromSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DesignerWorkflowVersion> result = await Obj.GetDesignerWorkflowVersionFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DesignerWorkflowVersion(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DesignerWorkflowVersion>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDesignerWorkflowVersion>> GetDesignerWorkflowVersionFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DesignerWorkflowVersion> result = await Obj.GetDesignerWorkflowVersionFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DesignerWorkflowVersion(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DesignerWorkflowVersion>(temp).ConfigureAwait(false);
        }

        public DesignerInstances GetDesignerInstancesFromInstancesRelation() => new DesignerInstances(Obj.GetDesignerInstancesFromInstancesRelation());

        public async Task<DeserializedHttpResponse<IDesignerInstances>> GetDesignerInstancesFromInstancesRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DesignerInstances> result = await Obj.GetDesignerInstancesFromInstancesRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DesignerInstances(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DesignerInstances>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDesignerInstances>> GetDesignerInstancesFromInstancesRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DesignerInstances> result = await Obj.GetDesignerInstancesFromInstancesRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DesignerInstances(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DesignerInstances>(temp).ConfigureAwait(false);
        }
    }
}

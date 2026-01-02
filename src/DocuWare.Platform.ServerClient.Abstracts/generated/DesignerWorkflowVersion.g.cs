using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DesignerWorkflowVersion(DocuWare.Platform.ServerClient.DesignerWorkflowVersion obj) : IDesignerWorkflowVersion
    {
        internal DocuWare.Platform.ServerClient.DesignerWorkflowVersion Obj { get; } = obj;

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

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public IDesignerWorkflowVersion GetDesignerWorkflowVersionFromSelfRelation() => new DesignerWorkflowVersion(Obj.GetDesignerWorkflowVersionFromSelfRelation());

        public async Task<DeserializedHttpResponse<IDesignerWorkflowVersion>> GetDesignerWorkflowVersionFromSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DesignerWorkflowVersion> result = await Obj.GetDesignerWorkflowVersionFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DesignerWorkflowVersion(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDesignerWorkflowVersion>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDesignerWorkflowVersion>> GetDesignerWorkflowVersionFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DesignerWorkflowVersion> result = await Obj.GetDesignerWorkflowVersionFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DesignerWorkflowVersion(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDesignerWorkflowVersion>(temp).ConfigureAwait(false);
        }

        public IDesignerInstances GetDesignerInstancesFromInstancesRelation() => new DesignerInstances(Obj.GetDesignerInstancesFromInstancesRelation());

        public async Task<DeserializedHttpResponse<IDesignerInstances>> GetDesignerInstancesFromInstancesRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DesignerInstances> result = await Obj.GetDesignerInstancesFromInstancesRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DesignerInstances(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDesignerInstances>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDesignerInstances>> GetDesignerInstancesFromInstancesRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DesignerInstances> result = await Obj.GetDesignerInstancesFromInstancesRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DesignerInstances(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDesignerInstances>(temp).ConfigureAwait(false);
        }
    }
}

using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DesignerWorkflow(SDK.DesignerWorkflow obj) : IDesignerWorkflow
    {
        internal SDK.DesignerWorkflow Obj { get; } = obj;

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

        public int InstanceCount
        {
            get => Obj.InstanceCount;
            set => Obj.InstanceCount = value;
        }

        public bool InstanceCountSpecified
        {
            get => Obj.InstanceCountSpecified;
            set => Obj.InstanceCountSpecified = value;
        }

        public string SelfRelationLink => Obj.SelfRelationLink;

        public string InstancesRelationLink => Obj.InstancesRelationLink;

        public string WaitingInstancesRelationLink => Obj.WaitingInstancesRelationLink;

        public string VersionsRelationLink => Obj.VersionsRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public DesignerWorkflow GetDesignerWorkflowFromSelfRelation() => new DesignerWorkflow(Obj.GetDesignerWorkflowFromSelfRelation());

        public async Task<DeserializedHttpResponse<IDesignerWorkflow>> GetDesignerWorkflowFromSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DesignerWorkflow> result = await Obj.GetDesignerWorkflowFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DesignerWorkflow(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DesignerWorkflow>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDesignerWorkflow>> GetDesignerWorkflowFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DesignerWorkflow> result = await Obj.GetDesignerWorkflowFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DesignerWorkflow(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DesignerWorkflow>(temp).ConfigureAwait(false);
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

        public DesignerWaitingInstances GetDesignerWaitingInstancesFromWaitingInstancesRelation() => new DesignerWaitingInstances(Obj.GetDesignerWaitingInstancesFromWaitingInstancesRelation());

        public async Task<DeserializedHttpResponse<IDesignerWaitingInstances>> GetDesignerWaitingInstancesFromWaitingInstancesRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DesignerWaitingInstances> result = await Obj.GetDesignerWaitingInstancesFromWaitingInstancesRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DesignerWaitingInstances(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DesignerWaitingInstances>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDesignerWaitingInstances>> GetDesignerWaitingInstancesFromWaitingInstancesRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DesignerWaitingInstances> result = await Obj.GetDesignerWaitingInstancesFromWaitingInstancesRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DesignerWaitingInstances(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DesignerWaitingInstances>(temp).ConfigureAwait(false);
        }

        public DesignerWorkflowVersions GetDesignerWorkflowVersionsFromVersionsRelation() => new DesignerWorkflowVersions(Obj.GetDesignerWorkflowVersionsFromVersionsRelation());

        public async Task<DeserializedHttpResponse<IDesignerWorkflowVersions>> GetDesignerWorkflowVersionsFromVersionsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DesignerWorkflowVersions> result = await Obj.GetDesignerWorkflowVersionsFromVersionsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DesignerWorkflowVersions(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DesignerWorkflowVersions>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDesignerWorkflowVersions>> GetDesignerWorkflowVersionsFromVersionsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DesignerWorkflowVersions> result = await Obj.GetDesignerWorkflowVersionsFromVersionsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DesignerWorkflowVersions(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DesignerWorkflowVersions>(temp).ConfigureAwait(false);
        }
    }
}

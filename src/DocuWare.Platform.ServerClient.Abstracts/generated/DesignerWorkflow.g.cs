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

        public IDesignerWorkflow GetDesignerWorkflowFromSelfRelation() => new DesignerWorkflow(Obj.GetDesignerWorkflowFromSelfRelation());

        public async Task<DeserializedHttpResponse<IDesignerWorkflow>> GetDesignerWorkflowFromSelfRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDesignerWorkflow result = await Obj.GetDesignerWorkflowFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDesignerWorkflow(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDesignerWorkflow>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDesignerWorkflow>> GetDesignerWorkflowFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDesignerWorkflow result = await Obj.GetDesignerWorkflowFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDesignerWorkflow(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDesignerWorkflow>(temp).ConfigureAwait(false);
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

        public IDesignerWaitingInstances GetDesignerWaitingInstancesFromWaitingInstancesRelation() => new DesignerWaitingInstances(Obj.GetDesignerWaitingInstancesFromWaitingInstancesRelation());

        public async Task<DeserializedHttpResponse<IDesignerWaitingInstances>> GetDesignerWaitingInstancesFromWaitingInstancesRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDesignerWaitingInstances result = await Obj.GetDesignerWaitingInstancesFromWaitingInstancesRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDesignerWaitingInstances(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDesignerWaitingInstances>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDesignerWaitingInstances>> GetDesignerWaitingInstancesFromWaitingInstancesRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDesignerWaitingInstances result = await Obj.GetDesignerWaitingInstancesFromWaitingInstancesRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDesignerWaitingInstances(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDesignerWaitingInstances>(temp).ConfigureAwait(false);
        }

        public IDesignerWorkflowVersions GetDesignerWorkflowVersionsFromVersionsRelation() => new DesignerWorkflowVersions(Obj.GetDesignerWorkflowVersionsFromVersionsRelation());

        public async Task<DeserializedHttpResponse<IDesignerWorkflowVersions>> GetDesignerWorkflowVersionsFromVersionsRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDesignerWorkflowVersions result = await Obj.GetDesignerWorkflowVersionsFromVersionsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDesignerWorkflowVersions(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDesignerWorkflowVersions>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDesignerWorkflowVersions>> GetDesignerWorkflowVersionsFromVersionsRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDesignerWorkflowVersions result = await Obj.GetDesignerWorkflowVersionsFromVersionsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDesignerWorkflowVersions(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDesignerWorkflowVersions>(temp).ConfigureAwait(false);
        }
    }
}

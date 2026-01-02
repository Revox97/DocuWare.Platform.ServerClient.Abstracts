using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DesignerInstance(SDK.DesignerInstance obj) : IDesignerInstance
    {
        internal SDK.DesignerInstance Obj { get; } = obj;

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

        public string WorkflowVersionId
        {
            get => Obj.WorkflowVersionId;
            set => Obj.WorkflowVersionId = value;
        }

        public DocuWare.Platform.ServerClient.InstanceExecutionStateEnum ExecutionState
        {
            get => Obj.ExecutionState;
            set => Obj.ExecutionState = value;
        }

        public int DocId
        {
            get => Obj.DocId;
            set => Obj.DocId = value;
        }

        public DateTime CreateDate
        {
            get => Obj.CreateDate;
            set => Obj.CreateDate = value;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public IDesignerInstance GetDesignerInstanceFromSelfRelation() => new DesignerInstance(Obj.GetDesignerInstanceFromSelfRelation());

        public async Task<DeserializedHttpResponse<IDesignerInstance>> GetDesignerInstanceFromSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DesignerInstance> result = await Obj.GetDesignerInstanceFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DesignerInstance(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDesignerInstance>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDesignerInstance>> GetDesignerInstanceFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DesignerInstance> result = await Obj.GetDesignerInstanceFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DesignerInstance(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDesignerInstance>(temp).ConfigureAwait(false);
        }

		public string DeleteSelfRelation() => Obj.DeleteSelfRelation();

		public async Task<DeserializedHttpResponse<string>> DeleteSelfRelationAsync() => await Obj.DeleteSelfRelationAsync();

		public async Task<DeserializedHttpResponse<string>> DeleteSelfRelationAsync(CancellationToken cancellationToken) => await Obj.DeleteSelfRelationAsync(cancellationToken);
    }
}

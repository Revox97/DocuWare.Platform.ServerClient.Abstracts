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

		public InstanceExecutionStateEnum ExecutionState
		{
			get => new nstanceExecutionStateEnum(Obj.ExecutionState);
			set => Obj.ExecutionState = ((nstanceExecutionStateEnum)value).Obj;
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

		public string SelfRelationLink => Obj.SelfRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
        public IDesignerInstance GetDesignerInstanceFromSelfRelation() => new DesignerInstance(Obj.GetDesignerInstanceFromSelfRelation());

        public async Task<DeserializedHttpResponse<IDesignerInstance>> GetDesignerInstanceFromSelfRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDesignerInstance result = await Obj.GetDesignerInstanceFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDesignerInstance(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDesignerInstance>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDesignerInstance>> GetDesignerInstanceFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDesignerInstance result = await Obj.GetDesignerInstanceFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDesignerInstance(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDesignerInstance>(temp).ConfigureAwait(false);
        }

		public async string DeleteSelfRelation() => Obj.DeleteSelfRelation();
        public async Task<DeserializedHttpResponse<string>> DeleteSelfRelationAsync()
        {
            DocuWare.Platform.ServerClient.string result = await Obj.DeleteSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<string>> DeleteSelfRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.string result = await Obj.DeleteSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

    }
}

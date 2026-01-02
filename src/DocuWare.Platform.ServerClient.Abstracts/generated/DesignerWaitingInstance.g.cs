using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DesignerWaitingInstance(DocuWare.Platform.ServerClient.DesignerWaitingInstance obj) : IDesignerWaitingInstance
    {
        internal DocuWare.Platform.ServerClient.DesignerWaitingInstance Obj { get; } = obj;

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

        public WaitInstanceActivityType WaitInstanceActivityType
        {
            get => (WaitInstanceActivityType)Obj.WaitInstanceActivityType;
            set => Obj.WaitInstanceActivityType = (DocuWare.Platform.ServerClient.WaitInstanceActivityType)value;
        }

        public string ActivityName
        {
            get => Obj.ActivityName;
            set => Obj.ActivityName = value;
        }

        public int DocId
        {
            get => Obj.DocId;
            set => Obj.DocId = value;
        }

        public DateTime TimeoutDate
        {
            get => Obj.TimeoutDate;
            set => Obj.TimeoutDate = value;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public IDesignerWaitingInstance GetDesignerWaitingInstanceFromSelfRelation() => new DesignerWaitingInstance(Obj.GetDesignerWaitingInstanceFromSelfRelation());

        public async Task<DeserializedHttpResponse<IDesignerWaitingInstance>> GetDesignerWaitingInstanceFromSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DesignerWaitingInstance> result = await Obj.GetDesignerWaitingInstanceFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DesignerWaitingInstance(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDesignerWaitingInstance>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDesignerWaitingInstance>> GetDesignerWaitingInstanceFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DesignerWaitingInstance> result = await Obj.GetDesignerWaitingInstanceFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DesignerWaitingInstance(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDesignerWaitingInstance>(temp).ConfigureAwait(false);
        }
    }
}

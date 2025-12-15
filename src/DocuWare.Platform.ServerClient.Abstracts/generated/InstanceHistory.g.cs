using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class InstanceHistory(SDK.InstanceHistory obj) : IInstanceHistory
    {
        internal SDK.InstanceHistory Obj { get; } = obj;

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public List<IHistoryStep> HistorySteps
        {
            get => Obj.HistorySteps.Select(x => new HistoryStep(x) as IHistoryStep).ToList();
            set => Obj.HistorySteps = value.Select(x => ((HistoryStep)x).Obj).ToList();
        }

        public string Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }

        public string WorkflowId
        {
            get => Obj.WorkflowId;
            set => Obj.WorkflowId = value;
        }

        public string Name
        {
            get => Obj.Name;
            set => Obj.Name = value;
        }

        public int Version
        {
            get => Obj.Version;
            set => Obj.Version = value;
        }

        public bool WorkflowRequest
        {
            get => Obj.WorkflowRequest;
            set => Obj.WorkflowRequest = value;
        }

        public DateTime StartedAt
        {
            get => Obj.StartedAt;
            set => Obj.StartedAt = value;
        }

        public int DocId
        {
            get => Obj.DocId;
            set => Obj.DocId = value;
        }

        public string SelfRelationLink => Obj.SelfRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public IInstanceHistory GetInstanceHistoryFromSelfRelation() => new InstanceHistory(Obj.GetInstanceHistoryFromSelfRelation());

        public async Task<DeserializedHttpResponse<IInstanceHistory>> GetInstanceHistoryFromSelfRelationAsync()
        {
            DocuWare.Platform.ServerClient.IInstanceHistory result = await Obj.GetInstanceHistoryFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IInstanceHistory(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IInstanceHistory>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IInstanceHistory>> GetInstanceHistoryFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IInstanceHistory result = await Obj.GetInstanceHistoryFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IInstanceHistory(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IInstanceHistory>(temp).ConfigureAwait(false);
        }
    }
}

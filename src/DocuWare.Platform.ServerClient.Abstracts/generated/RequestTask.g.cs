using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class RequestTask(SDK.RequestTask obj) : IRequestTask
    {
        internal SDK.RequestTask Obj { get; } = obj;

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public List<IRequestDecision> Decisions
        {
            get => Obj.Decisions.Select(x => new RequestDecision(x) as IRequestDecision).ToList();
            set => Obj.Decisions = value.Select(x => ((RequestDecision)x).Obj).ToList();
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

        public int DocId
        {
            get => Obj.DocId;
            set => Obj.DocId = value;
        }

        public string FcGuid
        {
            get => Obj.FcGuid;
            set => Obj.FcGuid = value;
        }

        public DateTime CreateDate
        {
            get => Obj.CreateDate;
            set => Obj.CreateDate = value;
        }

        public string Owner
        {
            get => Obj.Owner;
            set => Obj.Owner = value;
        }

        public string WorkflowName
        {
            get => Obj.WorkflowName;
            set => Obj.WorkflowName = value;
        }

        public string DocumentName
        {
            get => Obj.DocumentName;
            set => Obj.DocumentName = value;
        }

        public bool IsRead
        {
            get => Obj.IsRead;
            set => Obj.IsRead = value;
        }

        public string Description
        {
            get => Obj.Description;
            set => Obj.Description = value;
        }

        public bool AllowDecisionStamp
        {
            get => Obj.AllowDecisionStamp;
            set => Obj.AllowDecisionStamp = value;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public IRequestTask GetRequestTaskFromSelfRelation() => new RequestTask(Obj.GetRequestTaskFromSelfRelation());

        public async Task<DeserializedHttpResponse<IRequestTask>> GetRequestTaskFromSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.RequestTask> result = await Obj.GetRequestTaskFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new RequestTask(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IRequestTask>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IRequestTask>> GetRequestTaskFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.RequestTask> result = await Obj.GetRequestTaskFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new RequestTask(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IRequestTask>(temp).ConfigureAwait(false);
        }

		public string PutToReadStatusRelationForString(Stream dataToSend) => Obj.PutToReadStatusRelationForString(dataToSend);

		public async Task<DeserializedHttpResponse<string>> PutToReadStatusRelationForStringAsync(Stream dataToSend) => await Obj.PutToReadStatusRelationForStringAsync(dataToSend);

		public async Task<DeserializedHttpResponse<string>> PutToReadStatusRelationForStringAsync(CancellationToken cancellationToken, Stream dataToSend) => await Obj.PutToReadStatusRelationForStringAsync(cancellationToken, dataToSend);

        public IInstanceHistory GetInstanceHistoryFromHistoryRelation() => new InstanceHistory(Obj.GetInstanceHistoryFromHistoryRelation());

        public async Task<DeserializedHttpResponse<IInstanceHistory>> GetInstanceHistoryFromHistoryRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.InstanceHistory> result = await Obj.GetInstanceHistoryFromHistoryRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new InstanceHistory(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IInstanceHistory>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IInstanceHistory>> GetInstanceHistoryFromHistoryRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.InstanceHistory> result = await Obj.GetInstanceHistoryFromHistoryRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new InstanceHistory(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IInstanceHistory>(temp).ConfigureAwait(false);
        }

        public IRequestDecisionsStampSettings GetRequestDecisionsStampSettingsFromStampSettingsRelation() => new RequestDecisionsStampSettings(Obj.GetRequestDecisionsStampSettingsFromStampSettingsRelation());

        public async Task<DeserializedHttpResponse<IRequestDecisionsStampSettings>> GetRequestDecisionsStampSettingsFromStampSettingsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.RequestDecisionsStampSettings> result = await Obj.GetRequestDecisionsStampSettingsFromStampSettingsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new RequestDecisionsStampSettings(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IRequestDecisionsStampSettings>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IRequestDecisionsStampSettings>> GetRequestDecisionsStampSettingsFromStampSettingsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.RequestDecisionsStampSettings> result = await Obj.GetRequestDecisionsStampSettingsFromStampSettingsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new RequestDecisionsStampSettings(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IRequestDecisionsStampSettings>(temp).ConfigureAwait(false);
        }
    }
}

using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class HistoryInstance(SDK.HistoryInstance obj) : IHistoryInstance
    {
        internal SDK.HistoryInstance Obj { get; } = obj;

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public List<IColumnValue> ColumnValues
        {
            get => Obj.ColumnValues.Select(x => new ColumnValue(x) as IColumnValue).ToList();
            set => Obj.ColumnValues = value.Select(x => ((ColumnValue)x).Obj).ToList();
        }

        public string Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }

        public int DocId
        {
            get => Obj.DocId;
            set => Obj.DocId = value;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public IHistoryInstance GetHistoryInstanceFromSelfRelation() => new HistoryInstance(Obj.GetHistoryInstanceFromSelfRelation());

        public async Task<DeserializedHttpResponse<IHistoryInstance>> GetHistoryInstanceFromSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.HistoryInstance> result = await Obj.GetHistoryInstanceFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new HistoryInstance(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IHistoryInstance>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IHistoryInstance>> GetHistoryInstanceFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.HistoryInstance> result = await Obj.GetHistoryInstanceFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new HistoryInstance(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IHistoryInstance>(temp).ConfigureAwait(false);
        }

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
    }
}

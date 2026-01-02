using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BatchUpdateIndexFieldsResult(SDK.BatchUpdateIndexFieldsResult obj) : IBatchUpdateIndexFieldsResult
    {
        internal SDK.BatchUpdateIndexFieldsResult Obj { get; } = obj;

        public List<IBatchUpdateResultItem> Item
        {
            get => Obj.Item.Select(x => new BatchUpdateResultItem(x) as IBatchUpdateResultItem).ToList();
            set => Obj.Item = value.Select(x => ((BatchUpdateResultItem)x).Obj).ToList();
        }

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public int SuccessCount
        {
            get => Obj.SuccessCount;
            set => Obj.SuccessCount = value;
        }

        public string NextRelationLink => Obj.NextRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public BatchUpdateIndexFieldsResult PostToNextRelationForBatchUpdateIndexFieldsResult(IBatchUpdateProcessData dataToSend) => new BatchUpdateIndexFieldsResult(Obj.PostToNextRelationForBatchUpdateIndexFieldsResult(dataToSend));

        public async Task<DeserializedHttpResponse<IBatchUpdateIndexFieldsResult>> PostToNextRelationForBatchUpdateIndexFieldsResultAsync(IBatchUpdateProcessData dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.BatchUpdateIndexFieldsResult> result = await Obj.PostToNextRelationForBatchUpdateIndexFieldsResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new BatchUpdateIndexFieldsResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<BatchUpdateIndexFieldsResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IBatchUpdateIndexFieldsResult>> PostToNextRelationForBatchUpdateIndexFieldsResultAsync(CancellationToken cancellationToken, IBatchUpdateProcessData dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.BatchUpdateIndexFieldsResult> result = await Obj.PostToNextRelationForBatchUpdateIndexFieldsResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new BatchUpdateIndexFieldsResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<BatchUpdateIndexFieldsResult>(temp).ConfigureAwait(false);
        }
    }
}

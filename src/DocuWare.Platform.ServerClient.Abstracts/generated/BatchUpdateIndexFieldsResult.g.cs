using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BatchUpdateIndexFieldsResult(DocuWare.Platform.ServerClient.BatchUpdateIndexFieldsResult obj) : IBatchUpdateIndexFieldsResult
    {
        internal DocuWare.Platform.ServerClient.BatchUpdateIndexFieldsResult Obj { get; } = obj;

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

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public IBatchUpdateIndexFieldsResult PostToNextRelationForBatchUpdateIndexFieldsResult(IBatchUpdateProcessData dataToSend) => new BatchUpdateIndexFieldsResult(Obj.PostToNextRelationForBatchUpdateIndexFieldsResult(((BatchUpdateProcessData)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IBatchUpdateIndexFieldsResult>> PostToNextRelationForBatchUpdateIndexFieldsResultAsync(IBatchUpdateProcessData dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.BatchUpdateIndexFieldsResult> result = await Obj.PostToNextRelationForBatchUpdateIndexFieldsResultAsync(((BatchUpdateProcessData)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new BatchUpdateIndexFieldsResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IBatchUpdateIndexFieldsResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IBatchUpdateIndexFieldsResult>> PostToNextRelationForBatchUpdateIndexFieldsResultAsync(CancellationToken cancellationToken, IBatchUpdateProcessData dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.BatchUpdateIndexFieldsResult> result = await Obj.PostToNextRelationForBatchUpdateIndexFieldsResultAsync(cancellationToken, ((BatchUpdateProcessData)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new BatchUpdateIndexFieldsResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IBatchUpdateIndexFieldsResult>(temp).ConfigureAwait(false);
        }
    }
}

using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TrashBinDocumentsTableResult(SDK.TrashBinDocumentsTableResult obj) : ITrashBinDocumentsTableResult
    {
        internal SDK.TrashBinDocumentsTableResult Obj { get; } = obj;

        public ICountPlusValue Count
        {
            get => new CountPlusValue(Obj.Count);
            set => Obj.Count = ((CountPlusValue)value).Obj;
        }

        public List<ITrashBinTableHeader> Headers
        {
            get => Obj.Headers.Select(x => new TrashBinTableHeader(x) as ITrashBinTableHeader).ToList();
            set => Obj.Headers = value.Select(x => ((TrashBinTableHeader)x).Obj).ToList();
        }

        public List<ITrashBinTableRow> Rows
        {
            get => Obj.Rows.Select(x => new TrashBinTableRow(x) as ITrashBinTableRow).ToList();
            set => Obj.Rows = value.Select(x => ((TrashBinTableRow)x).Obj).ToList();
        }

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public DateTime TimeStamp
        {
            get => Obj.TimeStamp;
            set => Obj.TimeStamp = value;
        }

        public string NextRelationLink => Obj.NextRelationLink;

        public string PrevRelationLink => Obj.PrevRelationLink;

        public string SelfRelationLink => Obj.SelfRelationLink;

        public string FirstRelationLink => Obj.FirstRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public TrashBinDocumentsTableResult GetTrashBinDocumentsTableResultFromNextRelation() => new TrashBinDocumentsTableResult(Obj.GetTrashBinDocumentsTableResultFromNextRelation());

        public async Task<DeserializedHttpResponse<ITrashBinDocumentsTableResult>> GetTrashBinDocumentsTableResultFromNextRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.TrashBinDocumentsTableResult> result = await Obj.GetTrashBinDocumentsTableResultFromNextRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new TrashBinDocumentsTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<TrashBinDocumentsTableResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ITrashBinDocumentsTableResult>> GetTrashBinDocumentsTableResultFromNextRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.TrashBinDocumentsTableResult> result = await Obj.GetTrashBinDocumentsTableResultFromNextRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new TrashBinDocumentsTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<TrashBinDocumentsTableResult>(temp).ConfigureAwait(false);
        }

        public TrashBinDocumentsTableResult GetTrashBinDocumentsTableResultFromPrevRelation() => new TrashBinDocumentsTableResult(Obj.GetTrashBinDocumentsTableResultFromPrevRelation());

        public async Task<DeserializedHttpResponse<ITrashBinDocumentsTableResult>> GetTrashBinDocumentsTableResultFromPrevRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.TrashBinDocumentsTableResult> result = await Obj.GetTrashBinDocumentsTableResultFromPrevRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new TrashBinDocumentsTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<TrashBinDocumentsTableResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ITrashBinDocumentsTableResult>> GetTrashBinDocumentsTableResultFromPrevRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.TrashBinDocumentsTableResult> result = await Obj.GetTrashBinDocumentsTableResultFromPrevRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new TrashBinDocumentsTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<TrashBinDocumentsTableResult>(temp).ConfigureAwait(false);
        }

        public TrashBinDocumentsTableResult GetTrashBinDocumentsTableResultFromSelfRelation() => new TrashBinDocumentsTableResult(Obj.GetTrashBinDocumentsTableResultFromSelfRelation());

        public async Task<DeserializedHttpResponse<ITrashBinDocumentsTableResult>> GetTrashBinDocumentsTableResultFromSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.TrashBinDocumentsTableResult> result = await Obj.GetTrashBinDocumentsTableResultFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new TrashBinDocumentsTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<TrashBinDocumentsTableResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ITrashBinDocumentsTableResult>> GetTrashBinDocumentsTableResultFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.TrashBinDocumentsTableResult> result = await Obj.GetTrashBinDocumentsTableResultFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new TrashBinDocumentsTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<TrashBinDocumentsTableResult>(temp).ConfigureAwait(false);
        }

        public TrashBinDocumentsTableResult GetTrashBinDocumentsTableResultFromFirstRelation() => new TrashBinDocumentsTableResult(Obj.GetTrashBinDocumentsTableResultFromFirstRelation());

        public async Task<DeserializedHttpResponse<ITrashBinDocumentsTableResult>> GetTrashBinDocumentsTableResultFromFirstRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.TrashBinDocumentsTableResult> result = await Obj.GetTrashBinDocumentsTableResultFromFirstRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new TrashBinDocumentsTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<TrashBinDocumentsTableResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ITrashBinDocumentsTableResult>> GetTrashBinDocumentsTableResultFromFirstRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.TrashBinDocumentsTableResult> result = await Obj.GetTrashBinDocumentsTableResultFromFirstRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new TrashBinDocumentsTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<TrashBinDocumentsTableResult>(temp).ConfigureAwait(false);
        }
    }
}

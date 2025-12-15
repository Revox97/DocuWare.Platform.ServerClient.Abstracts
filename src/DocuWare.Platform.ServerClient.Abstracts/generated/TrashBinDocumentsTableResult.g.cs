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

        public ITrashBinDocumentsTableResult GetTrashBinDocumentsTableResultFromNextRelation() => new TrashBinDocumentsTableResult(Obj.GetTrashBinDocumentsTableResultFromNextRelation());

        public async Task<DeserializedHttpResponse<ITrashBinDocumentsTableResult>> GetTrashBinDocumentsTableResultFromNextRelationAsync()
        {
            DocuWare.Platform.ServerClient.ITrashBinDocumentsTableResult result = await Obj.GetTrashBinDocumentsTableResultFromNextRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ITrashBinDocumentsTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ITrashBinDocumentsTableResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ITrashBinDocumentsTableResult>> GetTrashBinDocumentsTableResultFromNextRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.ITrashBinDocumentsTableResult result = await Obj.GetTrashBinDocumentsTableResultFromNextRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ITrashBinDocumentsTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ITrashBinDocumentsTableResult>(temp).ConfigureAwait(false);
        }

        public ITrashBinDocumentsTableResult GetTrashBinDocumentsTableResultFromPrevRelation() => new TrashBinDocumentsTableResult(Obj.GetTrashBinDocumentsTableResultFromPrevRelation());

        public async Task<DeserializedHttpResponse<ITrashBinDocumentsTableResult>> GetTrashBinDocumentsTableResultFromPrevRelationAsync()
        {
            DocuWare.Platform.ServerClient.ITrashBinDocumentsTableResult result = await Obj.GetTrashBinDocumentsTableResultFromPrevRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ITrashBinDocumentsTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ITrashBinDocumentsTableResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ITrashBinDocumentsTableResult>> GetTrashBinDocumentsTableResultFromPrevRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.ITrashBinDocumentsTableResult result = await Obj.GetTrashBinDocumentsTableResultFromPrevRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ITrashBinDocumentsTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ITrashBinDocumentsTableResult>(temp).ConfigureAwait(false);
        }

        public ITrashBinDocumentsTableResult GetTrashBinDocumentsTableResultFromSelfRelation() => new TrashBinDocumentsTableResult(Obj.GetTrashBinDocumentsTableResultFromSelfRelation());

        public async Task<DeserializedHttpResponse<ITrashBinDocumentsTableResult>> GetTrashBinDocumentsTableResultFromSelfRelationAsync()
        {
            DocuWare.Platform.ServerClient.ITrashBinDocumentsTableResult result = await Obj.GetTrashBinDocumentsTableResultFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ITrashBinDocumentsTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ITrashBinDocumentsTableResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ITrashBinDocumentsTableResult>> GetTrashBinDocumentsTableResultFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.ITrashBinDocumentsTableResult result = await Obj.GetTrashBinDocumentsTableResultFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ITrashBinDocumentsTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ITrashBinDocumentsTableResult>(temp).ConfigureAwait(false);
        }

        public ITrashBinDocumentsTableResult GetTrashBinDocumentsTableResultFromFirstRelation() => new TrashBinDocumentsTableResult(Obj.GetTrashBinDocumentsTableResultFromFirstRelation());

        public async Task<DeserializedHttpResponse<ITrashBinDocumentsTableResult>> GetTrashBinDocumentsTableResultFromFirstRelationAsync()
        {
            DocuWare.Platform.ServerClient.ITrashBinDocumentsTableResult result = await Obj.GetTrashBinDocumentsTableResultFromFirstRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ITrashBinDocumentsTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ITrashBinDocumentsTableResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ITrashBinDocumentsTableResult>> GetTrashBinDocumentsTableResultFromFirstRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.ITrashBinDocumentsTableResult result = await Obj.GetTrashBinDocumentsTableResultFromFirstRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ITrashBinDocumentsTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ITrashBinDocumentsTableResult>(temp).ConfigureAwait(false);
        }
    }
}

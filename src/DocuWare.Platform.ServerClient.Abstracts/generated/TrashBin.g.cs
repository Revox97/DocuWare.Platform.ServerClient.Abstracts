using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TrashBin(SDK.TrashBin obj) : ITrashBin
    {
        internal SDK.TrashBin Obj { get; } = obj;

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public string DocumentsRelationLink => Obj.DocumentsRelationLink;

        public string QueryDocumentsRelationLink => Obj.QueryDocumentsRelationLink;

        public string CountDocumentsRelationLink => Obj.CountDocumentsRelationLink;

        public string SelectListsRelationLink => Obj.SelectListsRelationLink;

        public string BatchRestoreRelationLink => Obj.BatchRestoreRelationLink;

        public string BatchDeleteRelationLink => Obj.BatchDeleteRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public TrashBinDocumentsTableResult GetTrashBinDocumentsTableResultFromDocumentsRelation() => new TrashBinDocumentsTableResult(Obj.GetTrashBinDocumentsTableResultFromDocumentsRelation());

        public async Task<DeserializedHttpResponse<ITrashBinDocumentsTableResult>> GetTrashBinDocumentsTableResultFromDocumentsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.TrashBinDocumentsTableResult> result = await Obj.GetTrashBinDocumentsTableResultFromDocumentsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new TrashBinDocumentsTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<TrashBinDocumentsTableResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ITrashBinDocumentsTableResult>> GetTrashBinDocumentsTableResultFromDocumentsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.TrashBinDocumentsTableResult> result = await Obj.GetTrashBinDocumentsTableResultFromDocumentsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new TrashBinDocumentsTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<TrashBinDocumentsTableResult>(temp).ConfigureAwait(false);
        }

        public TrashBinDocumentsTableResult PostToQueryDocumentsRelationForTrashBinDocumentsTableResult(ITrashBinQuery dataToSend) => new TrashBinDocumentsTableResult(Obj.PostToQueryDocumentsRelationForTrashBinDocumentsTableResult(dataToSend));

        public async Task<DeserializedHttpResponse<ITrashBinDocumentsTableResult>> PostToQueryDocumentsRelationForTrashBinDocumentsTableResultAsync(ITrashBinQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.TrashBinDocumentsTableResult> result = await Obj.PostToQueryDocumentsRelationForTrashBinDocumentsTableResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new TrashBinDocumentsTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<TrashBinDocumentsTableResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ITrashBinDocumentsTableResult>> PostToQueryDocumentsRelationForTrashBinDocumentsTableResultAsync(CancellationToken cancellationToken, ITrashBinQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.TrashBinDocumentsTableResult> result = await Obj.PostToQueryDocumentsRelationForTrashBinDocumentsTableResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new TrashBinDocumentsTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<TrashBinDocumentsTableResult>(temp).ConfigureAwait(false);
        }

        public CountResult GetCountResultFromCountDocumentsRelation() => new CountResult(Obj.GetCountResultFromCountDocumentsRelation());

        public async Task<DeserializedHttpResponse<ICountResult>> GetCountResultFromCountDocumentsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.CountResult> result = await Obj.GetCountResultFromCountDocumentsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new CountResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<CountResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ICountResult>> GetCountResultFromCountDocumentsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.CountResult> result = await Obj.GetCountResultFromCountDocumentsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new CountResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<CountResult>(temp).ConfigureAwait(false);
        }

        public TypedSelectListResult GetTypedSelectListResultFromSelectListsRelation() => new TypedSelectListResult(Obj.GetTypedSelectListResultFromSelectListsRelation());

        public async Task<DeserializedHttpResponse<ITypedSelectListResult>> GetTypedSelectListResultFromSelectListsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.TypedSelectListResult> result = await Obj.GetTypedSelectListResultFromSelectListsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new TypedSelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<TypedSelectListResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ITypedSelectListResult>> GetTypedSelectListResultFromSelectListsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.TypedSelectListResult> result = await Obj.GetTypedSelectListResultFromSelectListsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new TypedSelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<TypedSelectListResult>(temp).ConfigureAwait(false);
        }

        public TypedSelectListResult PostToSelectListsRelationForTypedSelectListResult(ITrashBinSelectListExpression dataToSend) => new TypedSelectListResult(Obj.PostToSelectListsRelationForTypedSelectListResult(dataToSend));

        public async Task<DeserializedHttpResponse<ITypedSelectListResult>> PostToSelectListsRelationForTypedSelectListResultAsync(ITrashBinSelectListExpression dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.TypedSelectListResult> result = await Obj.PostToSelectListsRelationForTypedSelectListResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new TypedSelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<TypedSelectListResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ITypedSelectListResult>> PostToSelectListsRelationForTypedSelectListResultAsync(CancellationToken cancellationToken, ITrashBinSelectListExpression dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.TypedSelectListResult> result = await Obj.PostToSelectListsRelationForTypedSelectListResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new TypedSelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<TypedSelectListResult>(temp).ConfigureAwait(false);
        }

        public BatchRestoreResult PostToBatchRestoreRelationForBatchRestoreResult(IBatchRestoreDocumentsSource dataToSend) => new BatchRestoreResult(Obj.PostToBatchRestoreRelationForBatchRestoreResult(dataToSend));

        public async Task<DeserializedHttpResponse<IBatchRestoreResult>> PostToBatchRestoreRelationForBatchRestoreResultAsync(IBatchRestoreDocumentsSource dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.BatchRestoreResult> result = await Obj.PostToBatchRestoreRelationForBatchRestoreResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new BatchRestoreResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<BatchRestoreResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IBatchRestoreResult>> PostToBatchRestoreRelationForBatchRestoreResultAsync(CancellationToken cancellationToken, IBatchRestoreDocumentsSource dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.BatchRestoreResult> result = await Obj.PostToBatchRestoreRelationForBatchRestoreResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new BatchRestoreResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<BatchRestoreResult>(temp).ConfigureAwait(false);
        }

        public BatchDeleteResult PostToBatchDeleteRelationForBatchDeleteResult(IBatchDeleteDocumentsSource dataToSend) => new BatchDeleteResult(Obj.PostToBatchDeleteRelationForBatchDeleteResult(dataToSend));

        public async Task<DeserializedHttpResponse<IBatchDeleteResult>> PostToBatchDeleteRelationForBatchDeleteResultAsync(IBatchDeleteDocumentsSource dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.BatchDeleteResult> result = await Obj.PostToBatchDeleteRelationForBatchDeleteResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new BatchDeleteResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<BatchDeleteResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IBatchDeleteResult>> PostToBatchDeleteRelationForBatchDeleteResultAsync(CancellationToken cancellationToken, IBatchDeleteDocumentsSource dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.BatchDeleteResult> result = await Obj.PostToBatchDeleteRelationForBatchDeleteResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new BatchDeleteResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<BatchDeleteResult>(temp).ConfigureAwait(false);
        }
    }
}

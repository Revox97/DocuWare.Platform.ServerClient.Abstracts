using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TrashBin(DocuWare.Platform.ServerClient.TrashBin obj) : ITrashBin
    {
        internal DocuWare.Platform.ServerClient.TrashBin Obj { get; } = obj;

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public ITrashBinDocumentsTableResult GetTrashBinDocumentsTableResultFromDocumentsRelation() => new TrashBinDocumentsTableResult(Obj.GetTrashBinDocumentsTableResultFromDocumentsRelation());

        public async Task<DeserializedHttpResponse<ITrashBinDocumentsTableResult>> GetTrashBinDocumentsTableResultFromDocumentsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.TrashBinDocumentsTableResult> result = await Obj.GetTrashBinDocumentsTableResultFromDocumentsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new TrashBinDocumentsTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ITrashBinDocumentsTableResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ITrashBinDocumentsTableResult>> GetTrashBinDocumentsTableResultFromDocumentsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.TrashBinDocumentsTableResult> result = await Obj.GetTrashBinDocumentsTableResultFromDocumentsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new TrashBinDocumentsTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ITrashBinDocumentsTableResult>(temp).ConfigureAwait(false);
        }

        public ITrashBinDocumentsTableResult PostToQueryDocumentsRelationForTrashBinDocumentsTableResult(ITrashBinQuery dataToSend) => new TrashBinDocumentsTableResult(Obj.PostToQueryDocumentsRelationForTrashBinDocumentsTableResult(((TrashBinQuery)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<ITrashBinDocumentsTableResult>> PostToQueryDocumentsRelationForTrashBinDocumentsTableResultAsync(ITrashBinQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.TrashBinDocumentsTableResult> result = await Obj.PostToQueryDocumentsRelationForTrashBinDocumentsTableResultAsync(((TrashBinQuery)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new TrashBinDocumentsTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ITrashBinDocumentsTableResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ITrashBinDocumentsTableResult>> PostToQueryDocumentsRelationForTrashBinDocumentsTableResultAsync(CancellationToken cancellationToken, ITrashBinQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.TrashBinDocumentsTableResult> result = await Obj.PostToQueryDocumentsRelationForTrashBinDocumentsTableResultAsync(cancellationToken, ((TrashBinQuery)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new TrashBinDocumentsTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ITrashBinDocumentsTableResult>(temp).ConfigureAwait(false);
        }

        public ICountResult GetCountResultFromCountDocumentsRelation() => new CountResult(Obj.GetCountResultFromCountDocumentsRelation());

        public async Task<DeserializedHttpResponse<ICountResult>> GetCountResultFromCountDocumentsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.CountResult> result = await Obj.GetCountResultFromCountDocumentsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new CountResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ICountResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ICountResult>> GetCountResultFromCountDocumentsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.CountResult> result = await Obj.GetCountResultFromCountDocumentsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new CountResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ICountResult>(temp).ConfigureAwait(false);
        }

        public ITypedSelectListResult GetTypedSelectListResultFromSelectListsRelation() => new TypedSelectListResult(Obj.GetTypedSelectListResultFromSelectListsRelation());

        public async Task<DeserializedHttpResponse<ITypedSelectListResult>> GetTypedSelectListResultFromSelectListsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.TypedSelectListResult> result = await Obj.GetTypedSelectListResultFromSelectListsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new TypedSelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ITypedSelectListResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ITypedSelectListResult>> GetTypedSelectListResultFromSelectListsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.TypedSelectListResult> result = await Obj.GetTypedSelectListResultFromSelectListsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new TypedSelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ITypedSelectListResult>(temp).ConfigureAwait(false);
        }

        public ITypedSelectListResult PostToSelectListsRelationForTypedSelectListResult(ITrashBinSelectListExpression dataToSend) => new TypedSelectListResult(Obj.PostToSelectListsRelationForTypedSelectListResult(((TrashBinSelectListExpression)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<ITypedSelectListResult>> PostToSelectListsRelationForTypedSelectListResultAsync(ITrashBinSelectListExpression dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.TypedSelectListResult> result = await Obj.PostToSelectListsRelationForTypedSelectListResultAsync(((TrashBinSelectListExpression)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new TypedSelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ITypedSelectListResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ITypedSelectListResult>> PostToSelectListsRelationForTypedSelectListResultAsync(CancellationToken cancellationToken, ITrashBinSelectListExpression dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.TypedSelectListResult> result = await Obj.PostToSelectListsRelationForTypedSelectListResultAsync(cancellationToken, ((TrashBinSelectListExpression)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new TypedSelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ITypedSelectListResult>(temp).ConfigureAwait(false);
        }

        public IBatchRestoreResult PostToBatchRestoreRelationForBatchRestoreResult(IBatchRestoreDocumentsSource dataToSend) => new BatchRestoreResult(Obj.PostToBatchRestoreRelationForBatchRestoreResult(((BatchRestoreDocumentsSource)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IBatchRestoreResult>> PostToBatchRestoreRelationForBatchRestoreResultAsync(IBatchRestoreDocumentsSource dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.BatchRestoreResult> result = await Obj.PostToBatchRestoreRelationForBatchRestoreResultAsync(((BatchRestoreDocumentsSource)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new BatchRestoreResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IBatchRestoreResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IBatchRestoreResult>> PostToBatchRestoreRelationForBatchRestoreResultAsync(CancellationToken cancellationToken, IBatchRestoreDocumentsSource dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.BatchRestoreResult> result = await Obj.PostToBatchRestoreRelationForBatchRestoreResultAsync(cancellationToken, ((BatchRestoreDocumentsSource)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new BatchRestoreResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IBatchRestoreResult>(temp).ConfigureAwait(false);
        }

        public IBatchDeleteResult PostToBatchDeleteRelationForBatchDeleteResult(IBatchDeleteDocumentsSource dataToSend) => new BatchDeleteResult(Obj.PostToBatchDeleteRelationForBatchDeleteResult(((BatchDeleteDocumentsSource)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IBatchDeleteResult>> PostToBatchDeleteRelationForBatchDeleteResultAsync(IBatchDeleteDocumentsSource dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.BatchDeleteResult> result = await Obj.PostToBatchDeleteRelationForBatchDeleteResultAsync(((BatchDeleteDocumentsSource)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new BatchDeleteResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IBatchDeleteResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IBatchDeleteResult>> PostToBatchDeleteRelationForBatchDeleteResultAsync(CancellationToken cancellationToken, IBatchDeleteDocumentsSource dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.BatchDeleteResult> result = await Obj.PostToBatchDeleteRelationForBatchDeleteResultAsync(cancellationToken, ((BatchDeleteDocumentsSource)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new BatchDeleteResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IBatchDeleteResult>(temp).ConfigureAwait(false);
        }
    }
}

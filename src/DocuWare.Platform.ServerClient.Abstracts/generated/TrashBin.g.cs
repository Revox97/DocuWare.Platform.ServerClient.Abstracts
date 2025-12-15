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

        public ITrashBinDocumentsTableResult GetTrashBinDocumentsTableResultFromDocumentsRelation() => new TrashBinDocumentsTableResult(Obj.GetTrashBinDocumentsTableResultFromDocumentsRelation());

        public async Task<DeserializedHttpResponse<ITrashBinDocumentsTableResult>> GetTrashBinDocumentsTableResultFromDocumentsRelationAsync()
        {
            DocuWare.Platform.ServerClient.ITrashBinDocumentsTableResult result = await Obj.GetTrashBinDocumentsTableResultFromDocumentsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ITrashBinDocumentsTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ITrashBinDocumentsTableResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ITrashBinDocumentsTableResult>> GetTrashBinDocumentsTableResultFromDocumentsRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.ITrashBinDocumentsTableResult result = await Obj.GetTrashBinDocumentsTableResultFromDocumentsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ITrashBinDocumentsTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ITrashBinDocumentsTableResult>(temp).ConfigureAwait(false);
        }

        public ITrashBinDocumentsTableResult PostToQueryDocumentsRelationForTrashBinDocumentsTableResult(ITrashBinQuery dataToSend) => new TrashBinDocumentsTableResult(Obj.PostToQueryDocumentsRelationForTrashBinDocumentsTableResult(dataToSend));

        public async Task<DeserializedHttpResponse<ITrashBinDocumentsTableResult>> PostToQueryDocumentsRelationForTrashBinDocumentsTableResultAsync(ITrashBinQuery dataToSend)
        {
            DocuWare.Platform.ServerClient.ITrashBinDocumentsTableResult result = await Obj.PostToQueryDocumentsRelationForTrashBinDocumentsTableResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ITrashBinDocumentsTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ITrashBinDocumentsTableResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ITrashBinDocumentsTableResult>> PostToQueryDocumentsRelationForTrashBinDocumentsTableResultAsync(CancellationToken cancellationToken, ITrashBinQuery dataToSend)
        {
            DocuWare.Platform.ServerClient.ITrashBinDocumentsTableResult result = await Obj.PostToQueryDocumentsRelationForTrashBinDocumentsTableResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ITrashBinDocumentsTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ITrashBinDocumentsTableResult>(temp).ConfigureAwait(false);
        }

        public ICountResult GetCountResultFromCountDocumentsRelation() => new CountResult(Obj.GetCountResultFromCountDocumentsRelation());

        public async Task<DeserializedHttpResponse<ICountResult>> GetCountResultFromCountDocumentsRelationAsync()
        {
            DocuWare.Platform.ServerClient.ICountResult result = await Obj.GetCountResultFromCountDocumentsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ICountResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ICountResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ICountResult>> GetCountResultFromCountDocumentsRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.ICountResult result = await Obj.GetCountResultFromCountDocumentsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ICountResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ICountResult>(temp).ConfigureAwait(false);
        }

        public ITypedSelectListResult GetTypedSelectListResultFromSelectListsRelation() => new TypedSelectListResult(Obj.GetTypedSelectListResultFromSelectListsRelation());

        public async Task<DeserializedHttpResponse<ITypedSelectListResult>> GetTypedSelectListResultFromSelectListsRelationAsync()
        {
            DocuWare.Platform.ServerClient.ITypedSelectListResult result = await Obj.GetTypedSelectListResultFromSelectListsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ITypedSelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ITypedSelectListResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ITypedSelectListResult>> GetTypedSelectListResultFromSelectListsRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.ITypedSelectListResult result = await Obj.GetTypedSelectListResultFromSelectListsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ITypedSelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ITypedSelectListResult>(temp).ConfigureAwait(false);
        }

        public ITypedSelectListResult PostToSelectListsRelationForTypedSelectListResult(ITrashBinSelectListExpression dataToSend) => new TypedSelectListResult(Obj.PostToSelectListsRelationForTypedSelectListResult(dataToSend));

        public async Task<DeserializedHttpResponse<ITypedSelectListResult>> PostToSelectListsRelationForTypedSelectListResultAsync(ITrashBinSelectListExpression dataToSend)
        {
            DocuWare.Platform.ServerClient.ITypedSelectListResult result = await Obj.PostToSelectListsRelationForTypedSelectListResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ITypedSelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ITypedSelectListResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ITypedSelectListResult>> PostToSelectListsRelationForTypedSelectListResultAsync(CancellationToken cancellationToken, ITrashBinSelectListExpression dataToSend)
        {
            DocuWare.Platform.ServerClient.ITypedSelectListResult result = await Obj.PostToSelectListsRelationForTypedSelectListResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ITypedSelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ITypedSelectListResult>(temp).ConfigureAwait(false);
        }

        public IBatchRestoreResult PostToBatchRestoreRelationForBatchRestoreResult(IBatchRestoreDocumentsSource dataToSend) => new BatchRestoreResult(Obj.PostToBatchRestoreRelationForBatchRestoreResult(dataToSend));

        public async Task<DeserializedHttpResponse<IBatchRestoreResult>> PostToBatchRestoreRelationForBatchRestoreResultAsync(IBatchRestoreDocumentsSource dataToSend)
        {
            DocuWare.Platform.ServerClient.IBatchRestoreResult result = await Obj.PostToBatchRestoreRelationForBatchRestoreResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IBatchRestoreResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IBatchRestoreResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IBatchRestoreResult>> PostToBatchRestoreRelationForBatchRestoreResultAsync(CancellationToken cancellationToken, IBatchRestoreDocumentsSource dataToSend)
        {
            DocuWare.Platform.ServerClient.IBatchRestoreResult result = await Obj.PostToBatchRestoreRelationForBatchRestoreResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IBatchRestoreResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IBatchRestoreResult>(temp).ConfigureAwait(false);
        }

        public IBatchDeleteResult PostToBatchDeleteRelationForBatchDeleteResult(IBatchDeleteDocumentsSource dataToSend) => new BatchDeleteResult(Obj.PostToBatchDeleteRelationForBatchDeleteResult(dataToSend));

        public async Task<DeserializedHttpResponse<IBatchDeleteResult>> PostToBatchDeleteRelationForBatchDeleteResultAsync(IBatchDeleteDocumentsSource dataToSend)
        {
            DocuWare.Platform.ServerClient.IBatchDeleteResult result = await Obj.PostToBatchDeleteRelationForBatchDeleteResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IBatchDeleteResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IBatchDeleteResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IBatchDeleteResult>> PostToBatchDeleteRelationForBatchDeleteResultAsync(CancellationToken cancellationToken, IBatchDeleteDocumentsSource dataToSend)
        {
            DocuWare.Platform.ServerClient.IBatchDeleteResult result = await Obj.PostToBatchDeleteRelationForBatchDeleteResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IBatchDeleteResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IBatchDeleteResult>(temp).ConfigureAwait(false);
        }
    }
}

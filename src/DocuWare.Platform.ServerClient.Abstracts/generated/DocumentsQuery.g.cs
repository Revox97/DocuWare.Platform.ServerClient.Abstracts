using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentsQuery(SDK.DocumentsQuery obj) : IDocumentsQuery
    {
        internal SDK.DocumentsQuery Obj { get; } = obj;

        public bool ForceRefresh
        {
            get => Obj.ForceRefresh;
            set => Obj.ForceRefresh = value;
        }

        public string Expression
        {
            get => Obj.Expression;
            set => Obj.Expression = value;
        }

        public List<string> Fields
        {
            get => Obj.Fields;
            set => Obj.Fields = value;
        }

        public List<ISortedField> SortOrder
        {
            get => Obj.SortOrder.Select(x => new SortedField(x) as ISortedField).ToList();
            set => Obj.SortOrder = value.Select(x => ((SortedField)x).Obj).ToList();
        }

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public bool ExcludeSystemFields
        {
            get => Obj.ExcludeSystemFields;
            set => Obj.ExcludeSystemFields = value;
        }

        public bool IncludeSuggestions
        {
            get => Obj.IncludeSuggestions;
            set => Obj.IncludeSuggestions = value;
        }

        public bool CalculateTotalCount
        {
            get => Obj.CalculateTotalCount;
            set => Obj.CalculateTotalCount = value;
        }

        public string ResultRelationLink => Obj.ResultRelationLink;

        public string DialogExpressionRelationLink => Obj.DialogExpressionRelationLink;

        public string TableResultRelationLink => Obj.TableResultRelationLink;

        public string TableDialogExpressionRelationLink => Obj.TableDialogExpressionRelationLink;

        public string IdsResultRelationLink => Obj.IdsResultRelationLink;

        public string BatchUpdateRelationLink => Obj.BatchUpdateRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public IDocumentsQueryResult GetDocumentsQueryResultFromResultRelation() => new DocumentsQueryResult(Obj.GetDocumentsQueryResultFromResultRelation());

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromResultRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDocumentsQueryResult result = await Obj.GetDocumentsQueryResultFromResultRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromResultRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDocumentsQueryResult result = await Obj.GetDocumentsQueryResultFromResultRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public IDocumentsQueryResult PostToDialogExpressionRelationForDocumentsQueryResult(IDialogExpression dataToSend) => new DocumentsQueryResult(Obj.PostToDialogExpressionRelationForDocumentsQueryResult(dataToSend));

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToDialogExpressionRelationForDocumentsQueryResultAsync(IDialogExpression dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocumentsQueryResult result = await Obj.PostToDialogExpressionRelationForDocumentsQueryResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToDialogExpressionRelationForDocumentsQueryResultAsync(CancellationToken cancellationToken, IDialogExpression dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocumentsQueryResult result = await Obj.PostToDialogExpressionRelationForDocumentsQueryResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public IDocumentsQueryTableResult GetDocumentsQueryTableResultFromTableResultRelation() => new DocumentsQueryTableResult(Obj.GetDocumentsQueryTableResultFromTableResultRelation());

        public async Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromTableResultRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDocumentsQueryTableResult result = await Obj.GetDocumentsQueryTableResultFromTableResultRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentsQueryTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryTableResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromTableResultRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDocumentsQueryTableResult result = await Obj.GetDocumentsQueryTableResultFromTableResultRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentsQueryTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryTableResult>(temp).ConfigureAwait(false);
        }

        public IDocumentsQueryTableResult PostToTableDialogExpressionRelationForDocumentsQueryTableResult(IDialogExpression dataToSend) => new DocumentsQueryTableResult(Obj.PostToTableDialogExpressionRelationForDocumentsQueryTableResult(dataToSend));

        public async Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> PostToTableDialogExpressionRelationForDocumentsQueryTableResultAsync(IDialogExpression dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocumentsQueryTableResult result = await Obj.PostToTableDialogExpressionRelationForDocumentsQueryTableResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentsQueryTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryTableResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> PostToTableDialogExpressionRelationForDocumentsQueryTableResultAsync(CancellationToken cancellationToken, IDialogExpression dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocumentsQueryTableResult result = await Obj.PostToTableDialogExpressionRelationForDocumentsQueryTableResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentsQueryTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryTableResult>(temp).ConfigureAwait(false);
        }

        public ISelectListResult PostToIdsResultRelationForSelectListResult(ISelectListExpression dataToSend) => new SelectListResult(Obj.PostToIdsResultRelationForSelectListResult(dataToSend));

        public async Task<DeserializedHttpResponse<ISelectListResult>> PostToIdsResultRelationForSelectListResultAsync(ISelectListExpression dataToSend)
        {
            DocuWare.Platform.ServerClient.ISelectListResult result = await Obj.PostToIdsResultRelationForSelectListResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ISelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISelectListResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISelectListResult>> PostToIdsResultRelationForSelectListResultAsync(CancellationToken cancellationToken, ISelectListExpression dataToSend)
        {
            DocuWare.Platform.ServerClient.ISelectListResult result = await Obj.PostToIdsResultRelationForSelectListResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ISelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISelectListResult>(temp).ConfigureAwait(false);
        }

        public IBatchUpdateIndexFieldsResult PostToBatchUpdateRelationForBatchUpdateIndexFieldsResult(IBatchUpdateProcess dataToSend) => new BatchUpdateIndexFieldsResult(Obj.PostToBatchUpdateRelationForBatchUpdateIndexFieldsResult(dataToSend));

        public async Task<DeserializedHttpResponse<IBatchUpdateIndexFieldsResult>> PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(IBatchUpdateProcess dataToSend)
        {
            DocuWare.Platform.ServerClient.IBatchUpdateIndexFieldsResult result = await Obj.PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IBatchUpdateIndexFieldsResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IBatchUpdateIndexFieldsResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IBatchUpdateIndexFieldsResult>> PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(CancellationToken cancellationToken, IBatchUpdateProcess dataToSend)
        {
            DocuWare.Platform.ServerClient.IBatchUpdateIndexFieldsResult result = await Obj.PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IBatchUpdateIndexFieldsResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IBatchUpdateIndexFieldsResult>(temp).ConfigureAwait(false);
        }
    }
}

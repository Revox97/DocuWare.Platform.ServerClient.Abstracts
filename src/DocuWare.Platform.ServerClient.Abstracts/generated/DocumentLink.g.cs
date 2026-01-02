using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentLink(SDK.DocumentLink obj) : IDocumentLink
    {
        internal SDK.DocumentLink Obj { get; } = obj;

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public string Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }

        public string Name
        {
            get => Obj.Name;
            set => Obj.Name = value;
        }

        public bool IsInvalid
        {
            get => Obj.IsInvalid;
            set => Obj.IsInvalid = value;
        }

        public string TargetFileCabinet
        {
            get => Obj.TargetFileCabinet;
            set => Obj.TargetFileCabinet = value;
        }

        public string TargetResultList
        {
            get => Obj.TargetResultList;
            set => Obj.TargetResultList = value;
        }

        public string ResultRelationLink => Obj.ResultRelationLink;

        public string ResultDialogRelationLink => Obj.ResultDialogRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public DocumentsQueryResult GetDocumentsQueryResultFromResultRelation() => new DocumentsQueryResult(Obj.GetDocumentsQueryResultFromResultRelation());

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromResultRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.GetDocumentsQueryResultFromResultRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromResultRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.GetDocumentsQueryResultFromResultRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public DocumentsQueryResult PostToResultRelationForDocumentsQueryResult(IResultListQuery dataToSend) => new DocumentsQueryResult(Obj.PostToResultRelationForDocumentsQueryResult(dataToSend));

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToResultRelationForDocumentsQueryResultAsync(IResultListQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.PostToResultRelationForDocumentsQueryResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToResultRelationForDocumentsQueryResultAsync(CancellationToken cancellationToken, IResultListQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.PostToResultRelationForDocumentsQueryResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public DocumentsQueryResult PostToResultRelationForDocumentsQueryResult(IDocumentLinkExpressionQuery dataToSend) => new DocumentsQueryResult(Obj.PostToResultRelationForDocumentsQueryResult(dataToSend));

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToResultRelationForDocumentsQueryResultAsync(IDocumentLinkExpressionQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.PostToResultRelationForDocumentsQueryResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToResultRelationForDocumentsQueryResultAsync(CancellationToken cancellationToken, IDocumentLinkExpressionQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.PostToResultRelationForDocumentsQueryResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public Dialog GetDialogFromResultDialogRelation() => new Dialog(Obj.GetDialogFromResultDialogRelation());

        public async Task<DeserializedHttpResponse<IDialog>> GetDialogFromResultDialogRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Dialog> result = await Obj.GetDialogFromResultDialogRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Dialog(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Dialog>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDialog>> GetDialogFromResultDialogRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Dialog> result = await Obj.GetDialogFromResultDialogRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Dialog(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Dialog>(temp).ConfigureAwait(false);
        }
    }
}

using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DialogInfo(SDK.DialogInfo obj) : IDialogInfo
    {
        internal SDK.DialogInfo Obj { get; } = obj;

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

        public string FileCabinetId
        {
            get => Obj.FileCabinetId;
            set => Obj.FileCabinetId = value;
        }

        public string FileCabinetName
        {
            get => Obj.FileCabinetName;
            set => Obj.FileCabinetName = value;
        }

        public string DisplayName
        {
            get => Obj.DisplayName;
            set => Obj.DisplayName = value;
        }

        public bool IsForMobile
        {
            get => Obj.IsForMobile;
            set => Obj.IsForMobile = value;
        }

        public string AssignedDialogId
        {
            get => Obj.AssignedDialogId;
            set => Obj.AssignedDialogId = value;
        }

        public string Color
        {
            get => Obj.Color;
            set => Obj.Color = value;
        }

        public bool IsDefault
        {
            get => Obj.IsDefault;
            set => Obj.IsDefault = value;
        }

        public DocuWare.Platform.ServerClient.DialogTypes Type
        {
            get => Obj.Type;
            set => Obj.Type = value;
        }

        public string SelfRelationLink => Obj.SelfRelationLink;

        public string AssignedDialogRelationLink => Obj.AssignedDialogRelationLink;

        public string CountRelationLink => Obj.CountRelationLink;

        public string SelectListRelationLink => Obj.SelectListRelationLink;

        public string StoreDocumentRelationLink => Obj.StoreDocumentRelationLink;

        public string TransferRelationLink => Obj.TransferRelationLink;

        public string CreateUserDefinedSearchRelationLink => Obj.CreateUserDefinedSearchRelationLink;

        public string ClientSideValidationRelationLink => Obj.ClientSideValidationRelationLink;

		public async string ToString() => Obj.ToString();

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public Dialog GetDialogFromSelfRelation() => new Dialog(Obj.GetDialogFromSelfRelation());

        public async Task<DeserializedHttpResponse<IDialog>> GetDialogFromSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Dialog> result = await Obj.GetDialogFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Dialog(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Dialog>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDialog>> GetDialogFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Dialog> result = await Obj.GetDialogFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Dialog(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Dialog>(temp).ConfigureAwait(false);
        }

		public async string DeleteSelfRelation() => Obj.DeleteSelfRelation();

        public async Task<DeserializedHttpResponse<string>> DeleteSelfRelationAsync()
        {
            DeserializedHttpResponse<string> result = await Obj.DeleteSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<string>> DeleteSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<string> result = await Obj.DeleteSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public Dialog GetDialogFromAssignedDialogRelation() => new Dialog(Obj.GetDialogFromAssignedDialogRelation());

        public async Task<DeserializedHttpResponse<IDialog>> GetDialogFromAssignedDialogRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Dialog> result = await Obj.GetDialogFromAssignedDialogRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Dialog(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Dialog>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDialog>> GetDialogFromAssignedDialogRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Dialog> result = await Obj.GetDialogFromAssignedDialogRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Dialog(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Dialog>(temp).ConfigureAwait(false);
        }

        public CountResult GetCountResultFromCountRelation() => new CountResult(Obj.GetCountResultFromCountRelation());

        public async Task<DeserializedHttpResponse<ICountResult>> GetCountResultFromCountRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.CountResult> result = await Obj.GetCountResultFromCountRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new CountResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<CountResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ICountResult>> GetCountResultFromCountRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.CountResult> result = await Obj.GetCountResultFromCountRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new CountResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<CountResult>(temp).ConfigureAwait(false);
        }

        public CountResult PostToCountRelationForCountResult(ICountExpression dataToSend) => new CountResult(Obj.PostToCountRelationForCountResult(dataToSend));

        public async Task<DeserializedHttpResponse<ICountResult>> PostToCountRelationForCountResultAsync(ICountExpression dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.CountResult> result = await Obj.PostToCountRelationForCountResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new CountResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<CountResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ICountResult>> PostToCountRelationForCountResultAsync(CancellationToken cancellationToken, ICountExpression dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.CountResult> result = await Obj.PostToCountRelationForCountResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new CountResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<CountResult>(temp).ConfigureAwait(false);
        }

        public SelectListResult PostToSelectListRelationForSelectListResult(ISelectListExpression dataToSend) => new SelectListResult(Obj.PostToSelectListRelationForSelectListResult(dataToSend));

        public async Task<DeserializedHttpResponse<ISelectListResult>> PostToSelectListRelationForSelectListResultAsync(ISelectListExpression dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SelectListResult> result = await Obj.PostToSelectListRelationForSelectListResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<SelectListResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISelectListResult>> PostToSelectListRelationForSelectListResultAsync(CancellationToken cancellationToken, ISelectListExpression dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SelectListResult> result = await Obj.PostToSelectListRelationForSelectListResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<SelectListResult>(temp).ConfigureAwait(false);
        }

        public Document PostToStoreDocumentRelationForDocument(IDocument dataToSend) => new Document(Obj.PostToStoreDocumentRelationForDocument(dataToSend));

        public async Task<DeserializedHttpResponse<IDocument>> PostToStoreDocumentRelationForDocumentAsync(IDocument dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.PostToStoreDocumentRelationForDocumentAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Document>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocument>> PostToStoreDocumentRelationForDocumentAsync(CancellationToken cancellationToken, IDocument dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.PostToStoreDocumentRelationForDocumentAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Document>(temp).ConfigureAwait(false);
        }

        public DocumentsQueryResult PostToTransferRelationForDocumentsQueryResult(IFileCabinetTransferInfo dataToSend) => new DocumentsQueryResult(Obj.PostToTransferRelationForDocumentsQueryResult(dataToSend));

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToTransferRelationForDocumentsQueryResultAsync(IFileCabinetTransferInfo dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.PostToTransferRelationForDocumentsQueryResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToTransferRelationForDocumentsQueryResultAsync(CancellationToken cancellationToken, IFileCabinetTransferInfo dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.PostToTransferRelationForDocumentsQueryResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public DocumentsQueryResult PostToTransferRelationForDocumentsQueryResult(IDocumentsTransferInfo dataToSend) => new DocumentsQueryResult(Obj.PostToTransferRelationForDocumentsQueryResult(dataToSend));

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToTransferRelationForDocumentsQueryResultAsync(IDocumentsTransferInfo dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.PostToTransferRelationForDocumentsQueryResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToTransferRelationForDocumentsQueryResultAsync(CancellationToken cancellationToken, IDocumentsTransferInfo dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.PostToTransferRelationForDocumentsQueryResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public Dialog PostToCreateUserDefinedSearchRelationForDialog(IUserDefinedSearchInfo dataToSend) => new Dialog(Obj.PostToCreateUserDefinedSearchRelationForDialog(dataToSend));

        public async Task<DeserializedHttpResponse<IDialog>> PostToCreateUserDefinedSearchRelationForDialogAsync(IUserDefinedSearchInfo dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Dialog> result = await Obj.PostToCreateUserDefinedSearchRelationForDialogAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Dialog(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Dialog>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDialog>> PostToCreateUserDefinedSearchRelationForDialogAsync(CancellationToken cancellationToken, IUserDefinedSearchInfo dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Dialog> result = await Obj.PostToCreateUserDefinedSearchRelationForDialogAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Dialog(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Dialog>(temp).ConfigureAwait(false);
        }

		public async string PostToClientSideValidationRelationForString(IDocumentIndexFields dataToSend) => Obj.PostToClientSideValidationRelationForString(dataToSend);

        public async Task<DeserializedHttpResponse<string>> PostToClientSideValidationRelationForStringAsync(IDocumentIndexFields dataToSend)
        {
            DeserializedHttpResponse<string> result = await Obj.PostToClientSideValidationRelationForStringAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<string>> PostToClientSideValidationRelationForStringAsync(CancellationToken cancellationToken, IDocumentIndexFields dataToSend)
        {
            DeserializedHttpResponse<string> result = await Obj.PostToClientSideValidationRelationForStringAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }
    }
}

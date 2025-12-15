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

        public IDialog GetDialogFromSelfRelation() => new Dialog(Obj.GetDialogFromSelfRelation());

        public async Task<DeserializedHttpResponse<IDialog>> GetDialogFromSelfRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDialog result = await Obj.GetDialogFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDialog(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialog>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDialog>> GetDialogFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDialog result = await Obj.GetDialogFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDialog(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialog>(temp).ConfigureAwait(false);
        }

		public async string DeleteSelfRelation() => Obj.DeleteSelfRelation();

        public async Task<DeserializedHttpResponse<string>> DeleteSelfRelationAsync()
        {
            DocuWare.Platform.ServerClient.string result = await Obj.DeleteSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<string>> DeleteSelfRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.string result = await Obj.DeleteSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public IDialog GetDialogFromAssignedDialogRelation() => new Dialog(Obj.GetDialogFromAssignedDialogRelation());

        public async Task<DeserializedHttpResponse<IDialog>> GetDialogFromAssignedDialogRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDialog result = await Obj.GetDialogFromAssignedDialogRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDialog(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialog>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDialog>> GetDialogFromAssignedDialogRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDialog result = await Obj.GetDialogFromAssignedDialogRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDialog(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialog>(temp).ConfigureAwait(false);
        }

        public ICountResult GetCountResultFromCountRelation() => new CountResult(Obj.GetCountResultFromCountRelation());

        public async Task<DeserializedHttpResponse<ICountResult>> GetCountResultFromCountRelationAsync()
        {
            DocuWare.Platform.ServerClient.ICountResult result = await Obj.GetCountResultFromCountRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ICountResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ICountResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ICountResult>> GetCountResultFromCountRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.ICountResult result = await Obj.GetCountResultFromCountRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ICountResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ICountResult>(temp).ConfigureAwait(false);
        }

        public ICountResult PostToCountRelationForCountResult(ICountExpression dataToSend) => new CountResult(Obj.PostToCountRelationForCountResult(dataToSend));

        public async Task<DeserializedHttpResponse<ICountResult>> PostToCountRelationForCountResultAsync(ICountExpression dataToSend)
        {
            DocuWare.Platform.ServerClient.ICountResult result = await Obj.PostToCountRelationForCountResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ICountResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ICountResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ICountResult>> PostToCountRelationForCountResultAsync(CancellationToken cancellationToken, ICountExpression dataToSend)
        {
            DocuWare.Platform.ServerClient.ICountResult result = await Obj.PostToCountRelationForCountResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ICountResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ICountResult>(temp).ConfigureAwait(false);
        }

        public ISelectListResult PostToSelectListRelationForSelectListResult(ISelectListExpression dataToSend) => new SelectListResult(Obj.PostToSelectListRelationForSelectListResult(dataToSend));

        public async Task<DeserializedHttpResponse<ISelectListResult>> PostToSelectListRelationForSelectListResultAsync(ISelectListExpression dataToSend)
        {
            DocuWare.Platform.ServerClient.ISelectListResult result = await Obj.PostToSelectListRelationForSelectListResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ISelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISelectListResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISelectListResult>> PostToSelectListRelationForSelectListResultAsync(CancellationToken cancellationToken, ISelectListExpression dataToSend)
        {
            DocuWare.Platform.ServerClient.ISelectListResult result = await Obj.PostToSelectListRelationForSelectListResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ISelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISelectListResult>(temp).ConfigureAwait(false);
        }

        public IDocument PostToStoreDocumentRelationForDocument(IDocument dataToSend) => new Document(Obj.PostToStoreDocumentRelationForDocument(dataToSend));

        public async Task<DeserializedHttpResponse<IDocument>> PostToStoreDocumentRelationForDocumentAsync(IDocument dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocument result = await Obj.PostToStoreDocumentRelationForDocumentAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocument(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocument>> PostToStoreDocumentRelationForDocumentAsync(CancellationToken cancellationToken, IDocument dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocument result = await Obj.PostToStoreDocumentRelationForDocumentAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocument(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public IDocumentsQueryResult PostToTransferRelationForDocumentsQueryResult(IFileCabinetTransferInfo dataToSend) => new DocumentsQueryResult(Obj.PostToTransferRelationForDocumentsQueryResult(dataToSend));

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToTransferRelationForDocumentsQueryResultAsync(IFileCabinetTransferInfo dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocumentsQueryResult result = await Obj.PostToTransferRelationForDocumentsQueryResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToTransferRelationForDocumentsQueryResultAsync(CancellationToken cancellationToken, IFileCabinetTransferInfo dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocumentsQueryResult result = await Obj.PostToTransferRelationForDocumentsQueryResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public IDocumentsQueryResult PostToTransferRelationForDocumentsQueryResult(IDocumentsTransferInfo dataToSend) => new DocumentsQueryResult(Obj.PostToTransferRelationForDocumentsQueryResult(dataToSend));

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToTransferRelationForDocumentsQueryResultAsync(IDocumentsTransferInfo dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocumentsQueryResult result = await Obj.PostToTransferRelationForDocumentsQueryResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToTransferRelationForDocumentsQueryResultAsync(CancellationToken cancellationToken, IDocumentsTransferInfo dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocumentsQueryResult result = await Obj.PostToTransferRelationForDocumentsQueryResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public IDialog PostToCreateUserDefinedSearchRelationForDialog(IUserDefinedSearchInfo dataToSend) => new Dialog(Obj.PostToCreateUserDefinedSearchRelationForDialog(dataToSend));

        public async Task<DeserializedHttpResponse<IDialog>> PostToCreateUserDefinedSearchRelationForDialogAsync(IUserDefinedSearchInfo dataToSend)
        {
            DocuWare.Platform.ServerClient.IDialog result = await Obj.PostToCreateUserDefinedSearchRelationForDialogAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDialog(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialog>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDialog>> PostToCreateUserDefinedSearchRelationForDialogAsync(CancellationToken cancellationToken, IUserDefinedSearchInfo dataToSend)
        {
            DocuWare.Platform.ServerClient.IDialog result = await Obj.PostToCreateUserDefinedSearchRelationForDialogAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDialog(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialog>(temp).ConfigureAwait(false);
        }

		public async string PostToClientSideValidationRelationForString(IDocumentIndexFields dataToSend) => Obj.PostToClientSideValidationRelationForString(dataToSend);

        public async Task<DeserializedHttpResponse<string>> PostToClientSideValidationRelationForStringAsync(IDocumentIndexFields dataToSend)
        {
            DocuWare.Platform.ServerClient.string result = await Obj.PostToClientSideValidationRelationForStringAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<string>> PostToClientSideValidationRelationForStringAsync(CancellationToken cancellationToken, IDocumentIndexFields dataToSend)
        {
            DocuWare.Platform.ServerClient.string result = await Obj.PostToClientSideValidationRelationForStringAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }
    }
}

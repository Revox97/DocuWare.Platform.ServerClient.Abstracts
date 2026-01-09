using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Dialog(DocuWare.Platform.ServerClient.Dialog obj) : IDialog
    {
        internal DocuWare.Platform.ServerClient.Dialog Obj { get; } = obj;

        public List<IDialogField> Fields
        {
            get => Obj.Fields.Select(x => new DialogField(x) as IDialogField).ToList();
            set => Obj.Fields = value.Select(x => ((DialogField)x).Obj).ToList();
        }

        public bool HasValidation
        {
            get => Obj.HasValidation;
            set => Obj.HasValidation = value;
        }

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

        public DialogTypes Type
        {
            get => (DialogTypes)Obj.Type;
            set => Obj.Type = (DocuWare.Platform.ServerClient.DialogTypes)value;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

		public override string ToString() => Obj.ToString();

        public IDialog GetDialogFromSelfRelation() => new Dialog(Obj.GetDialogFromSelfRelation());

        public async Task<DeserializedHttpResponse<IDialog>> GetDialogFromSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Dialog> result = await Obj.GetDialogFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Dialog(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialog>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDialog>> GetDialogFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Dialog> result = await Obj.GetDialogFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Dialog(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialog>(temp).ConfigureAwait(false);
        }

		public string DeleteSelfRelation() => Obj.DeleteSelfRelation();

		public async Task<DeserializedHttpResponse<string>> DeleteSelfRelationAsync() => await Obj.DeleteSelfRelationAsync();

		public async Task<DeserializedHttpResponse<string>> DeleteSelfRelationAsync(CancellationToken cancellationToken) => await Obj.DeleteSelfRelationAsync(cancellationToken);

        public IDialog GetDialogFromAssignedDialogRelation() => new Dialog(Obj.GetDialogFromAssignedDialogRelation());

        public async Task<DeserializedHttpResponse<IDialog>> GetDialogFromAssignedDialogRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Dialog> result = await Obj.GetDialogFromAssignedDialogRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Dialog(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialog>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDialog>> GetDialogFromAssignedDialogRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Dialog> result = await Obj.GetDialogFromAssignedDialogRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Dialog(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialog>(temp).ConfigureAwait(false);
        }

        public ICountResult GetCountResultFromCountRelation() => new CountResult(Obj.GetCountResultFromCountRelation());

        public async Task<DeserializedHttpResponse<ICountResult>> GetCountResultFromCountRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.CountResult> result = await Obj.GetCountResultFromCountRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new CountResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ICountResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ICountResult>> GetCountResultFromCountRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.CountResult> result = await Obj.GetCountResultFromCountRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new CountResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ICountResult>(temp).ConfigureAwait(false);
        }

        public ICountResult PostToCountRelationForCountResult(ICountExpression dataToSend) => new CountResult(Obj.PostToCountRelationForCountResult(((CountExpression)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<ICountResult>> PostToCountRelationForCountResultAsync(ICountExpression dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.CountResult> result = await Obj.PostToCountRelationForCountResultAsync(((CountExpression)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new CountResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ICountResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ICountResult>> PostToCountRelationForCountResultAsync(CancellationToken cancellationToken, ICountExpression dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.CountResult> result = await Obj.PostToCountRelationForCountResultAsync(cancellationToken, ((CountExpression)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new CountResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ICountResult>(temp).ConfigureAwait(false);
        }

        public ISelectListResult PostToSelectListRelationForSelectListResult(ISelectListExpression dataToSend) => new SelectListResult(Obj.PostToSelectListRelationForSelectListResult(((SelectListExpression)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<ISelectListResult>> PostToSelectListRelationForSelectListResultAsync(ISelectListExpression dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SelectListResult> result = await Obj.PostToSelectListRelationForSelectListResultAsync(((SelectListExpression)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISelectListResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISelectListResult>> PostToSelectListRelationForSelectListResultAsync(CancellationToken cancellationToken, ISelectListExpression dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SelectListResult> result = await Obj.PostToSelectListRelationForSelectListResultAsync(cancellationToken, ((SelectListExpression)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISelectListResult>(temp).ConfigureAwait(false);
        }

        public IDocument PostToStoreDocumentRelationForDocument(IDocument dataToSend) => new Document(Obj.PostToStoreDocumentRelationForDocument(((Document)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IDocument>> PostToStoreDocumentRelationForDocumentAsync(IDocument dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.PostToStoreDocumentRelationForDocumentAsync(((Document)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocument>> PostToStoreDocumentRelationForDocumentAsync(CancellationToken cancellationToken, IDocument dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.PostToStoreDocumentRelationForDocumentAsync(cancellationToken, ((Document)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public IDocumentsQueryResult PostToTransferRelationForDocumentsQueryResult(IFileCabinetTransferInfo dataToSend) => new DocumentsQueryResult(Obj.PostToTransferRelationForDocumentsQueryResult(((FileCabinetTransferInfo)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToTransferRelationForDocumentsQueryResultAsync(IFileCabinetTransferInfo dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.PostToTransferRelationForDocumentsQueryResultAsync(((FileCabinetTransferInfo)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToTransferRelationForDocumentsQueryResultAsync(CancellationToken cancellationToken, IFileCabinetTransferInfo dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.PostToTransferRelationForDocumentsQueryResultAsync(cancellationToken, ((FileCabinetTransferInfo)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public IDocumentsQueryResult PostToTransferRelationForDocumentsQueryResult(IDocumentsTransferInfo dataToSend) => new DocumentsQueryResult(Obj.PostToTransferRelationForDocumentsQueryResult(((DocumentsTransferInfo)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToTransferRelationForDocumentsQueryResultAsync(IDocumentsTransferInfo dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.PostToTransferRelationForDocumentsQueryResultAsync(((DocumentsTransferInfo)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToTransferRelationForDocumentsQueryResultAsync(CancellationToken cancellationToken, IDocumentsTransferInfo dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.PostToTransferRelationForDocumentsQueryResultAsync(cancellationToken, ((DocumentsTransferInfo)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public IDialog PostToCreateUserDefinedSearchRelationForDialog(IUserDefinedSearchInfo dataToSend) => new Dialog(Obj.PostToCreateUserDefinedSearchRelationForDialog(((UserDefinedSearchInfo)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IDialog>> PostToCreateUserDefinedSearchRelationForDialogAsync(IUserDefinedSearchInfo dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Dialog> result = await Obj.PostToCreateUserDefinedSearchRelationForDialogAsync(((UserDefinedSearchInfo)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Dialog(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialog>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDialog>> PostToCreateUserDefinedSearchRelationForDialogAsync(CancellationToken cancellationToken, IUserDefinedSearchInfo dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Dialog> result = await Obj.PostToCreateUserDefinedSearchRelationForDialogAsync(cancellationToken, ((UserDefinedSearchInfo)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Dialog(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialog>(temp).ConfigureAwait(false);
        }

		public string PostToClientSideValidationRelationForString(IDocumentIndexFields dataToSend) => Obj.PostToClientSideValidationRelationForString(((DocumentIndexFields)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<string>> PostToClientSideValidationRelationForStringAsync(IDocumentIndexFields dataToSend) => await Obj.PostToClientSideValidationRelationForStringAsync(((DocumentIndexFields)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<string>> PostToClientSideValidationRelationForStringAsync(CancellationToken cancellationToken, IDocumentIndexFields dataToSend) => await Obj.PostToClientSideValidationRelationForStringAsync(cancellationToken, ((DocumentIndexFields)dataToSend).Obj);
    }
}

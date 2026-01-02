using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FileCabinetFieldBase(SDK.FileCabinetFieldBase obj) : IFileCabinetFieldBase
    {
        internal SDK.FileCabinetFieldBase Obj { get; } = obj;

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public string FixedEntry
        {
            get => Obj.FixedEntry;
            set => Obj.FixedEntry = value;
        }

        public string FieldInfoText
        {
            get => Obj.FieldInfoText;
            set => Obj.FieldInfoText = value;
        }

        public DocuWare.Platform.ServerClient.FileCabinetFieldScope Scope
        {
            get => Obj.Scope;
            set => Obj.Scope = value;
        }

        public DocuWare.Platform.ServerClient.DWFieldType DWFieldType
        {
            get => Obj.DWFieldType;
            set => Obj.DWFieldType = value;
        }

        public int Length
        {
            get => Obj.Length;
            set => Obj.Length = value;
        }

        public string DBFieldName
        {
            get => Obj.DBFieldName;
            set => Obj.DBFieldName = value;
        }

        public string DisplayName
        {
            get => Obj.DisplayName;
            set => Obj.DisplayName = value;
        }

        public bool DropLeadingZero
        {
            get => Obj.DropLeadingZero;
            set => Obj.DropLeadingZero = value;
        }

        public bool DropLeadingBlanks
        {
            get => Obj.DropLeadingBlanks;
            set => Obj.DropLeadingBlanks = value;
        }

        public bool NotEmpty
        {
            get => Obj.NotEmpty;
            set => Obj.NotEmpty = value;
        }

        public int Precision
        {
            get => Obj.Precision;
            set => Obj.Precision = value;
        }

        public string SelectListRelationLink => Obj.SelectListRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public SelectListResult GetSelectListResultFromSelectListRelation() => new SelectListResult(Obj.GetSelectListResultFromSelectListRelation());

        public async Task<DeserializedHttpResponse<ISelectListResult>> GetSelectListResultFromSelectListRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SelectListResult> result = await Obj.GetSelectListResultFromSelectListRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<SelectListResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISelectListResult>> GetSelectListResultFromSelectListRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SelectListResult> result = await Obj.GetSelectListResultFromSelectListRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<SelectListResult>(temp).ConfigureAwait(false);
        }

        public SelectListResult PostToSelectListRelationForSelectListResult(IFileCabinetSelectListExpression dataToSend) => new SelectListResult(Obj.PostToSelectListRelationForSelectListResult(dataToSend));

        public async Task<DeserializedHttpResponse<ISelectListResult>> PostToSelectListRelationForSelectListResultAsync(IFileCabinetSelectListExpression dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SelectListResult> result = await Obj.PostToSelectListRelationForSelectListResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<SelectListResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISelectListResult>> PostToSelectListRelationForSelectListResultAsync(CancellationToken cancellationToken, IFileCabinetSelectListExpression dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SelectListResult> result = await Obj.PostToSelectListRelationForSelectListResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<SelectListResult>(temp).ConfigureAwait(false);
        }
    }
}

using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DialogFieldBase(DocuWare.Platform.ServerClient.DialogFieldBase obj) : IDialogFieldBase
    {
        internal DocuWare.Platform.ServerClient.DialogFieldBase Obj { get; } = obj;

        public string SampleEditText
        {
            get => Obj.SampleEditText;
            set => Obj.SampleEditText = value;
        }

        public List<IDocumentIndexFieldValue> PrefillValue
        {
            get => Obj.PrefillValue.Select(x => new DocumentIndexFieldValue(x) as IDocumentIndexFieldValue).ToList();
            set => Obj.PrefillValue = value.Select(x => ((DocumentIndexFieldValue)x).Obj).ToList();
        }

        public List<DynamicValueType> DynamicPrefillValue
        {
            get => Obj.DynamicPrefillValue;
            set => Obj.DynamicPrefillValue = value;
        }

        public List<ISelectListInfo> SelectListInfos
        {
            get => Obj.SelectListInfos.Select(x => new SelectListInfo(x) as ISelectListInfo).ToList();
            set => Obj.SelectListInfos = value.Select(x => ((SelectListInfo)x).Obj).ToList();
        }

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public string DBFieldName
        {
            get => Obj.DBFieldName;
            set => Obj.DBFieldName = value;
        }

        public string DlgLabel
        {
            get => Obj.DlgLabel;
            set => Obj.DlgLabel = value;
        }

        public DWFieldType DWFieldType
        {
            get => (DWFieldType)Obj.DWFieldType;
            set => Obj.DWFieldType = (DocuWare.Platform.ServerClient.DWFieldType)value;
        }

        public bool Locked
        {
            get => Obj.Locked;
            set => Obj.Locked = value;
        }

        public bool ReadOnly
        {
            get => Obj.ReadOnly;
            set => Obj.ReadOnly = value;
        }

        public bool NotEmpty
        {
            get => Obj.NotEmpty;
            set => Obj.NotEmpty = value;
        }

        public bool Visible
        {
            get => Obj.Visible;
            set => Obj.Visible = value;
        }

        public int Length
        {
            get => Obj.Length;
            set => Obj.Length = value;
        }

        public int Precision
        {
            get => Obj.Precision;
            set => Obj.Precision = value;
        }

        public bool AllowExtendedSearch
        {
            get => Obj.AllowExtendedSearch;
            set => Obj.AllowExtendedSearch = value;
        }

        public bool AllowFiltering
        {
            get => Obj.AllowFiltering;
            set => Obj.AllowFiltering = value;
        }

        public bool SelectListOnly
        {
            get => Obj.SelectListOnly;
            set => Obj.SelectListOnly = value;
        }

        public SelectListType SelectListType
        {
            get => (SelectListType)Obj.SelectListType;
            set => Obj.SelectListType = (DocuWare.Platform.ServerClient.SelectListType)value;
        }

        public bool AssignedInternalSelectList
        {
            get => Obj.AssignedInternalSelectList;
            set => Obj.AssignedInternalSelectList = value;
        }

        public string SequenceId
        {
            get => Obj.SequenceId;
            set => Obj.SequenceId = value;
        }

        public bool SelectListsAssigned
        {
            get => Obj.SelectListsAssigned;
            set => Obj.SelectListsAssigned = value;
        }

        public bool CalculateSum
        {
            get => Obj.CalculateSum;
            set => Obj.CalculateSum = value;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public ISelectListResult GetSelectListResultFromSimpleSelectListRelation() => new SelectListResult(Obj.GetSelectListResultFromSimpleSelectListRelation());

        public async Task<DeserializedHttpResponse<ISelectListResult>> GetSelectListResultFromSimpleSelectListRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SelectListResult> result = await Obj.GetSelectListResultFromSimpleSelectListRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISelectListResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISelectListResult>> GetSelectListResultFromSimpleSelectListRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SelectListResult> result = await Obj.GetSelectListResultFromSimpleSelectListRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISelectListResult>(temp).ConfigureAwait(false);
        }

        public ISelectListResult PostToSimpleSelectListRelationForSelectListResult(ISelectListExpression dataToSend) => new SelectListResult(Obj.PostToSimpleSelectListRelationForSelectListResult(((SelectListExpression)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<ISelectListResult>> PostToSimpleSelectListRelationForSelectListResultAsync(ISelectListExpression dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SelectListResult> result = await Obj.PostToSimpleSelectListRelationForSelectListResultAsync(((SelectListExpression)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISelectListResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISelectListResult>> PostToSimpleSelectListRelationForSelectListResultAsync(CancellationToken cancellationToken, ISelectListExpression dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SelectListResult> result = await Obj.PostToSimpleSelectListRelationForSelectListResultAsync(cancellationToken, ((SelectListExpression)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISelectListResult>(temp).ConfigureAwait(false);
        }
    }
}

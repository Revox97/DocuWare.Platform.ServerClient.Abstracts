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

		public FileCabinetFieldScope Scope
		{
			get => new ileCabinetFieldScope(Obj.Scope);
			set => Obj.Scope = ((ileCabinetFieldScope)value).Obj;
		}

		public DWFieldType DWFieldType
		{
			get => new WFieldType(Obj.DWFieldType);
			set => Obj.DWFieldType = ((WFieldType)value).Obj;
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
        public ISelectListResult GetSelectListResultFromSelectListRelation() => new SelectListResult(Obj.GetSelectListResultFromSelectListRelation());

        public async Task<DeserializedHttpResponse<ISelectListResult>> GetSelectListResultFromSelectListRelationAsync()
        {
            DocuWare.Platform.ServerClient.ISelectListResult result = await Obj.GetSelectListResultFromSelectListRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ISelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISelectListResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISelectListResult>> GetSelectListResultFromSelectListRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.ISelectListResult result = await Obj.GetSelectListResultFromSelectListRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ISelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISelectListResult>(temp).ConfigureAwait(false);
        }

        public ISelectListResult PostToSelectListRelationForSelectListResult(IFileCabinetSelectListExpression dataToSend) => new SelectListResult(Obj.PostToSelectListRelationForSelectListResult(dataToSend));

        public async Task<DeserializedHttpResponse<ISelectListResult>> PostToSelectListRelationForSelectListResultAsync(IFileCabinetSelectListExpression dataToSend)
        {
            DocuWare.Platform.ServerClient.ISelectListResult result = await Obj.PostToSelectListRelationForSelectListResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ISelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISelectListResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISelectListResult>> PostToSelectListRelationForSelectListResultAsync(CancellationToken cancellationToken, IFileCabinetSelectListExpression dataToSend)
        {
            DocuWare.Platform.ServerClient.ISelectListResult result = await Obj.PostToSelectListRelationForSelectListResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ISelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISelectListResult>(temp).ConfigureAwait(false);
        }

    }
}

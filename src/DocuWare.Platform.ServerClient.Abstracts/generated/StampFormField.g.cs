using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class StampFormField(DocuWare.Platform.ServerClient.StampFormField obj) : IStampFormField
    {
        internal DocuWare.Platform.ServerClient.StampFormField Obj { get; } = obj;

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public string Name
        {
            get => Obj.Name;
            set => Obj.Name = value;
        }

        public string Label
        {
            get => Obj.Label;
            set => Obj.Label = value;
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

        public DocuWare.Platform.ServerClient.DWFieldType DWFieldType
        {
            get => Obj.DWFieldType;
            set => Obj.DWFieldType = value;
        }

        public string Mask
        {
            get => Obj.Mask;
            set => Obj.Mask = value;
        }

        public string MaskErrorText
        {
            get => Obj.MaskErrorText;
            set => Obj.MaskErrorText = value;
        }

        public string SampleEditText
        {
            get => Obj.SampleEditText;
            set => Obj.SampleEditText = value;
        }

        public bool SelectListsAssigned
        {
            get => Obj.SelectListsAssigned;
            set => Obj.SelectListsAssigned = value;
        }

        public bool NotEmpty
        {
            get => Obj.NotEmpty;
            set => Obj.NotEmpty = value;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public ISelectListResult GetSelectListResultFromSelectListValuesRelation() => new SelectListResult(Obj.GetSelectListResultFromSelectListValuesRelation());

        public async Task<DeserializedHttpResponse<ISelectListResult>> GetSelectListResultFromSelectListValuesRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SelectListResult> result = await Obj.GetSelectListResultFromSelectListValuesRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISelectListResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISelectListResult>> GetSelectListResultFromSelectListValuesRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SelectListResult> result = await Obj.GetSelectListResultFromSelectListValuesRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISelectListResult>(temp).ConfigureAwait(false);
        }

        public ISelectListResult PostToSelectListValuesRelationForSelectListResult(ISelectListExpression dataToSend) => new SelectListResult(Obj.PostToSelectListValuesRelationForSelectListResult(((SelectListExpression)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<ISelectListResult>> PostToSelectListValuesRelationForSelectListResultAsync(ISelectListExpression dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SelectListResult> result = await Obj.PostToSelectListValuesRelationForSelectListResultAsync(((SelectListExpression)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISelectListResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISelectListResult>> PostToSelectListValuesRelationForSelectListResultAsync(CancellationToken cancellationToken, ISelectListExpression dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SelectListResult> result = await Obj.PostToSelectListValuesRelationForSelectListResultAsync(cancellationToken, ((SelectListExpression)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISelectListResult>(temp).ConfigureAwait(false);
        }

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

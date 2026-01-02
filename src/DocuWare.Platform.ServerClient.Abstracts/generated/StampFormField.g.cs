using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class StampFormField(SDK.StampFormField obj) : IStampFormField
    {
        internal SDK.StampFormField Obj { get; } = obj;

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

        public string SelectListValuesRelationLink => Obj.SelectListValuesRelationLink;

        public string SimpleSelectListRelationLink => Obj.SimpleSelectListRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public SelectListResult GetSelectListResultFromSelectListValuesRelation() => new SelectListResult(Obj.GetSelectListResultFromSelectListValuesRelation());

        public async Task<DeserializedHttpResponse<ISelectListResult>> GetSelectListResultFromSelectListValuesRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SelectListResult> result = await Obj.GetSelectListResultFromSelectListValuesRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<SelectListResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISelectListResult>> GetSelectListResultFromSelectListValuesRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SelectListResult> result = await Obj.GetSelectListResultFromSelectListValuesRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<SelectListResult>(temp).ConfigureAwait(false);
        }

        public SelectListResult PostToSelectListValuesRelationForSelectListResult(ISelectListExpression dataToSend) => new SelectListResult(Obj.PostToSelectListValuesRelationForSelectListResult(dataToSend));

        public async Task<DeserializedHttpResponse<ISelectListResult>> PostToSelectListValuesRelationForSelectListResultAsync(ISelectListExpression dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SelectListResult> result = await Obj.PostToSelectListValuesRelationForSelectListResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<SelectListResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISelectListResult>> PostToSelectListValuesRelationForSelectListResultAsync(CancellationToken cancellationToken, ISelectListExpression dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SelectListResult> result = await Obj.PostToSelectListValuesRelationForSelectListResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<SelectListResult>(temp).ConfigureAwait(false);
        }

        public SelectListResult GetSelectListResultFromSimpleSelectListRelation() => new SelectListResult(Obj.GetSelectListResultFromSimpleSelectListRelation());

        public async Task<DeserializedHttpResponse<ISelectListResult>> GetSelectListResultFromSimpleSelectListRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SelectListResult> result = await Obj.GetSelectListResultFromSimpleSelectListRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<SelectListResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISelectListResult>> GetSelectListResultFromSimpleSelectListRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SelectListResult> result = await Obj.GetSelectListResultFromSimpleSelectListRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<SelectListResult>(temp).ConfigureAwait(false);
        }

        public SelectListResult PostToSimpleSelectListRelationForSelectListResult(ISelectListExpression dataToSend) => new SelectListResult(Obj.PostToSimpleSelectListRelationForSelectListResult(dataToSend));

        public async Task<DeserializedHttpResponse<ISelectListResult>> PostToSimpleSelectListRelationForSelectListResultAsync(ISelectListExpression dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SelectListResult> result = await Obj.PostToSimpleSelectListRelationForSelectListResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<SelectListResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISelectListResult>> PostToSimpleSelectListRelationForSelectListResultAsync(CancellationToken cancellationToken, ISelectListExpression dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SelectListResult> result = await Obj.PostToSimpleSelectListRelationForSelectListResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<SelectListResult>(temp).ConfigureAwait(false);
        }
    }
}

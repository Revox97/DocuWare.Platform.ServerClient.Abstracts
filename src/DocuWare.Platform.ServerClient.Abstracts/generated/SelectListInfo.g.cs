using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SelectListInfo(SDK.SelectListInfo obj) : ISelectListInfo
    {
        internal SDK.SelectListInfo Obj { get; } = obj;

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public string Guid
        {
            get => Obj.Guid;
            set => Obj.Guid = value;
        }

        public string Name
        {
            get => Obj.Name;
            set => Obj.Name = value;
        }

        public DocuWare.Platform.ServerClient.SelectListKind Kind
        {
            get => Obj.Kind;
            set => Obj.Kind = value;
        }

        public string ValuesRelationLink => Obj.ValuesRelationLink;

        public string ContainsRelationLink => Obj.ContainsRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public SelectListValuesResult GetSelectListValuesResultFromValuesRelation() => new SelectListValuesResult(Obj.GetSelectListValuesResultFromValuesRelation());

        public async Task<DeserializedHttpResponse<ISelectListValuesResult>> GetSelectListValuesResultFromValuesRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SelectListValuesResult> result = await Obj.GetSelectListValuesResultFromValuesRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SelectListValuesResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<SelectListValuesResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISelectListValuesResult>> GetSelectListValuesResultFromValuesRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SelectListValuesResult> result = await Obj.GetSelectListValuesResultFromValuesRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SelectListValuesResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<SelectListValuesResult>(temp).ConfigureAwait(false);
        }

        public SelectListValuesResult PostToValuesRelationForSelectListValuesResult(ISelectListValuesQuery dataToSend) => new SelectListValuesResult(Obj.PostToValuesRelationForSelectListValuesResult(dataToSend));

        public async Task<DeserializedHttpResponse<ISelectListValuesResult>> PostToValuesRelationForSelectListValuesResultAsync(ISelectListValuesQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SelectListValuesResult> result = await Obj.PostToValuesRelationForSelectListValuesResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SelectListValuesResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<SelectListValuesResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISelectListValuesResult>> PostToValuesRelationForSelectListValuesResultAsync(CancellationToken cancellationToken, ISelectListValuesQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SelectListValuesResult> result = await Obj.PostToValuesRelationForSelectListValuesResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SelectListValuesResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<SelectListValuesResult>(temp).ConfigureAwait(false);
        }

        public AreValuesInSelectListsResult PostToContainsRelationForAreValuesInSelectListsResult(ISelectListValuesToCheck dataToSend) => new AreValuesInSelectListsResult(Obj.PostToContainsRelationForAreValuesInSelectListsResult(dataToSend));

        public async Task<DeserializedHttpResponse<IAreValuesInSelectListsResult>> PostToContainsRelationForAreValuesInSelectListsResultAsync(ISelectListValuesToCheck dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.AreValuesInSelectListsResult> result = await Obj.PostToContainsRelationForAreValuesInSelectListsResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new AreValuesInSelectListsResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<AreValuesInSelectListsResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IAreValuesInSelectListsResult>> PostToContainsRelationForAreValuesInSelectListsResultAsync(CancellationToken cancellationToken, ISelectListValuesToCheck dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.AreValuesInSelectListsResult> result = await Obj.PostToContainsRelationForAreValuesInSelectListsResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new AreValuesInSelectListsResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<AreValuesInSelectListsResult>(temp).ConfigureAwait(false);
        }
    }
}

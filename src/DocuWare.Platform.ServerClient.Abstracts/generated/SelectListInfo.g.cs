using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SelectListInfo(DocuWare.Platform.ServerClient.SelectListInfo obj) : ISelectListInfo
    {
        internal DocuWare.Platform.ServerClient.SelectListInfo Obj { get; } = obj;

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

        public SelectListKind Kind
        {
            get => (SelectListKind)Obj.Kind;
            set => Obj.Kind = (DocuWare.Platform.ServerClient.SelectListKind)value;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public ISelectListValuesResult GetSelectListValuesResultFromValuesRelation() => new SelectListValuesResult(Obj.GetSelectListValuesResultFromValuesRelation());

        public async Task<DeserializedHttpResponse<ISelectListValuesResult>> GetSelectListValuesResultFromValuesRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SelectListValuesResult> result = await Obj.GetSelectListValuesResultFromValuesRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SelectListValuesResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISelectListValuesResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISelectListValuesResult>> GetSelectListValuesResultFromValuesRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SelectListValuesResult> result = await Obj.GetSelectListValuesResultFromValuesRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SelectListValuesResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISelectListValuesResult>(temp).ConfigureAwait(false);
        }

        public ISelectListValuesResult PostToValuesRelationForSelectListValuesResult(ISelectListValuesQuery dataToSend) => new SelectListValuesResult(Obj.PostToValuesRelationForSelectListValuesResult(((SelectListValuesQuery)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<ISelectListValuesResult>> PostToValuesRelationForSelectListValuesResultAsync(ISelectListValuesQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SelectListValuesResult> result = await Obj.PostToValuesRelationForSelectListValuesResultAsync(((SelectListValuesQuery)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SelectListValuesResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISelectListValuesResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISelectListValuesResult>> PostToValuesRelationForSelectListValuesResultAsync(CancellationToken cancellationToken, ISelectListValuesQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SelectListValuesResult> result = await Obj.PostToValuesRelationForSelectListValuesResultAsync(cancellationToken, ((SelectListValuesQuery)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SelectListValuesResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISelectListValuesResult>(temp).ConfigureAwait(false);
        }

        public IAreValuesInSelectListsResult PostToContainsRelationForAreValuesInSelectListsResult(ISelectListValuesToCheck dataToSend) => new AreValuesInSelectListsResult(Obj.PostToContainsRelationForAreValuesInSelectListsResult(((SelectListValuesToCheck)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IAreValuesInSelectListsResult>> PostToContainsRelationForAreValuesInSelectListsResultAsync(ISelectListValuesToCheck dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.AreValuesInSelectListsResult> result = await Obj.PostToContainsRelationForAreValuesInSelectListsResultAsync(((SelectListValuesToCheck)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new AreValuesInSelectListsResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IAreValuesInSelectListsResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IAreValuesInSelectListsResult>> PostToContainsRelationForAreValuesInSelectListsResultAsync(CancellationToken cancellationToken, ISelectListValuesToCheck dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.AreValuesInSelectListsResult> result = await Obj.PostToContainsRelationForAreValuesInSelectListsResultAsync(cancellationToken, ((SelectListValuesToCheck)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new AreValuesInSelectListsResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IAreValuesInSelectListsResult>(temp).ConfigureAwait(false);
        }
    }
}

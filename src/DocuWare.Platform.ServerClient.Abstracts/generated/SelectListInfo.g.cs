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

        public ISelectListValuesResult GetSelectListValuesResultFromValuesRelation() => new SelectListValuesResult(Obj.GetSelectListValuesResultFromValuesRelation());

        public async Task<DeserializedHttpResponse<ISelectListValuesResult>> GetSelectListValuesResultFromValuesRelationAsync()
        {
            DocuWare.Platform.ServerClient.ISelectListValuesResult result = await Obj.GetSelectListValuesResultFromValuesRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ISelectListValuesResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISelectListValuesResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISelectListValuesResult>> GetSelectListValuesResultFromValuesRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.ISelectListValuesResult result = await Obj.GetSelectListValuesResultFromValuesRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ISelectListValuesResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISelectListValuesResult>(temp).ConfigureAwait(false);
        }

        public ISelectListValuesResult PostToValuesRelationForSelectListValuesResult(ISelectListValuesQuery dataToSend) => new SelectListValuesResult(Obj.PostToValuesRelationForSelectListValuesResult(dataToSend));

        public async Task<DeserializedHttpResponse<ISelectListValuesResult>> PostToValuesRelationForSelectListValuesResultAsync(ISelectListValuesQuery dataToSend)
        {
            DocuWare.Platform.ServerClient.ISelectListValuesResult result = await Obj.PostToValuesRelationForSelectListValuesResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ISelectListValuesResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISelectListValuesResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISelectListValuesResult>> PostToValuesRelationForSelectListValuesResultAsync(CancellationToken cancellationToken, ISelectListValuesQuery dataToSend)
        {
            DocuWare.Platform.ServerClient.ISelectListValuesResult result = await Obj.PostToValuesRelationForSelectListValuesResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ISelectListValuesResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISelectListValuesResult>(temp).ConfigureAwait(false);
        }

        public IAreValuesInSelectListsResult PostToContainsRelationForAreValuesInSelectListsResult(ISelectListValuesToCheck dataToSend) => new AreValuesInSelectListsResult(Obj.PostToContainsRelationForAreValuesInSelectListsResult(dataToSend));

        public async Task<DeserializedHttpResponse<IAreValuesInSelectListsResult>> PostToContainsRelationForAreValuesInSelectListsResultAsync(ISelectListValuesToCheck dataToSend)
        {
            DocuWare.Platform.ServerClient.IAreValuesInSelectListsResult result = await Obj.PostToContainsRelationForAreValuesInSelectListsResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IAreValuesInSelectListsResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IAreValuesInSelectListsResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IAreValuesInSelectListsResult>> PostToContainsRelationForAreValuesInSelectListsResultAsync(CancellationToken cancellationToken, ISelectListValuesToCheck dataToSend)
        {
            DocuWare.Platform.ServerClient.IAreValuesInSelectListsResult result = await Obj.PostToContainsRelationForAreValuesInSelectListsResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IAreValuesInSelectListsResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IAreValuesInSelectListsResult>(temp).ConfigureAwait(false);
        }
    }
}

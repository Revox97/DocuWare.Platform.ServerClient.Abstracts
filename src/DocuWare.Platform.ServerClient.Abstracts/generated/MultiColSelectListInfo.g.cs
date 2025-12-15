using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class MultiColSelectListInfo(SDK.MultiColSelectListInfo obj) : IMultiColSelectListInfo
    {
        internal SDK.MultiColSelectListInfo Obj { get; } = obj;

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public List<string> Columns
        {
            get => Obj.Columns;
            set => Obj.Columns = value;
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

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public IMultiColSelectListValuesResult GetMultiColSelectListValuesResultFromValuesRelation() => new MultiColSelectListValuesResult(Obj.GetMultiColSelectListValuesResultFromValuesRelation());

        public async Task<DeserializedHttpResponse<IMultiColSelectListValuesResult>> GetMultiColSelectListValuesResultFromValuesRelationAsync()
        {
            DocuWare.Platform.ServerClient.IMultiColSelectListValuesResult result = await Obj.GetMultiColSelectListValuesResultFromValuesRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IMultiColSelectListValuesResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IMultiColSelectListValuesResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IMultiColSelectListValuesResult>> GetMultiColSelectListValuesResultFromValuesRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IMultiColSelectListValuesResult result = await Obj.GetMultiColSelectListValuesResultFromValuesRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IMultiColSelectListValuesResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IMultiColSelectListValuesResult>(temp).ConfigureAwait(false);
        }

        public IMultiColSelectListValuesResult PostToValuesRelationForMultiColSelectListValuesResult(IMultiColSelectListValuesQuery dataToSend) => new MultiColSelectListValuesResult(Obj.PostToValuesRelationForMultiColSelectListValuesResult(dataToSend));

        public async Task<DeserializedHttpResponse<IMultiColSelectListValuesResult>> PostToValuesRelationForMultiColSelectListValuesResultAsync(IMultiColSelectListValuesQuery dataToSend)
        {
            DocuWare.Platform.ServerClient.IMultiColSelectListValuesResult result = await Obj.PostToValuesRelationForMultiColSelectListValuesResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IMultiColSelectListValuesResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IMultiColSelectListValuesResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IMultiColSelectListValuesResult>> PostToValuesRelationForMultiColSelectListValuesResultAsync(CancellationToken cancellationToken, IMultiColSelectListValuesQuery dataToSend)
        {
            DocuWare.Platform.ServerClient.IMultiColSelectListValuesResult result = await Obj.PostToValuesRelationForMultiColSelectListValuesResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IMultiColSelectListValuesResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IMultiColSelectListValuesResult>(temp).ConfigureAwait(false);
        }
    }
}

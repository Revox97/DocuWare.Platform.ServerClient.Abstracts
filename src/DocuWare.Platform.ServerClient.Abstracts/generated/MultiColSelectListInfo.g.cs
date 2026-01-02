using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class MultiColSelectListInfo(DocuWare.Platform.ServerClient.MultiColSelectListInfo obj) : IMultiColSelectListInfo
    {
        internal DocuWare.Platform.ServerClient.MultiColSelectListInfo Obj { get; } = obj;

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

        public SelectListKind Kind
        {
            get => (SelectListKind)Obj.Kind;
            set => Obj.Kind = (DocuWare.Platform.ServerClient.SelectListKind)value;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public IMultiColSelectListValuesResult GetMultiColSelectListValuesResultFromValuesRelation() => new MultiColSelectListValuesResult(Obj.GetMultiColSelectListValuesResultFromValuesRelation());

        public async Task<DeserializedHttpResponse<IMultiColSelectListValuesResult>> GetMultiColSelectListValuesResultFromValuesRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.MultiColSelectListValuesResult> result = await Obj.GetMultiColSelectListValuesResultFromValuesRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new MultiColSelectListValuesResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IMultiColSelectListValuesResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IMultiColSelectListValuesResult>> GetMultiColSelectListValuesResultFromValuesRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.MultiColSelectListValuesResult> result = await Obj.GetMultiColSelectListValuesResultFromValuesRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new MultiColSelectListValuesResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IMultiColSelectListValuesResult>(temp).ConfigureAwait(false);
        }

        public IMultiColSelectListValuesResult PostToValuesRelationForMultiColSelectListValuesResult(IMultiColSelectListValuesQuery dataToSend) => new MultiColSelectListValuesResult(Obj.PostToValuesRelationForMultiColSelectListValuesResult(((MultiColSelectListValuesQuery)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IMultiColSelectListValuesResult>> PostToValuesRelationForMultiColSelectListValuesResultAsync(IMultiColSelectListValuesQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.MultiColSelectListValuesResult> result = await Obj.PostToValuesRelationForMultiColSelectListValuesResultAsync(((MultiColSelectListValuesQuery)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new MultiColSelectListValuesResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IMultiColSelectListValuesResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IMultiColSelectListValuesResult>> PostToValuesRelationForMultiColSelectListValuesResultAsync(CancellationToken cancellationToken, IMultiColSelectListValuesQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.MultiColSelectListValuesResult> result = await Obj.PostToValuesRelationForMultiColSelectListValuesResultAsync(cancellationToken, ((MultiColSelectListValuesQuery)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new MultiColSelectListValuesResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IMultiColSelectListValuesResult>(temp).ConfigureAwait(false);
        }
    }
}

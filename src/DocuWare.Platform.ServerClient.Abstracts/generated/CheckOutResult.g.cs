using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class CheckOutResult(DocuWare.Platform.ServerClient.CheckOutResult obj) : ICheckOutResult
    {
        internal DocuWare.Platform.ServerClient.CheckOutResult Obj { get; } = obj;

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public string ContentRelationLink => Obj.ContentRelationLink;

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

		public Stream GetStreamFromContentRelation() => Obj.GetStreamFromContentRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromContentRelationAsync() => await Obj.GetStreamFromContentRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromContentRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromContentRelationAsync(cancellationToken);
    }
}

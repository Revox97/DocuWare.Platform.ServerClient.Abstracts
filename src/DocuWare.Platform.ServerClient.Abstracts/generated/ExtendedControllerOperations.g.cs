using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ExtendedControllerOperations(DocuWare.Platform.ServerClient.ExtendedControllerOperations obj) : IExtendedControllerOperations
    {
        internal DocuWare.Platform.ServerClient.ExtendedControllerOperations Obj { get; } = obj;

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

		public string DeleteInstanceRelation() => Obj.DeleteInstanceRelation();

		public async Task<DeserializedHttpResponse<string>> DeleteInstanceRelationAsync() => await Obj.DeleteInstanceRelationAsync();

		public async Task<DeserializedHttpResponse<string>> DeleteInstanceRelationAsync(CancellationToken cancellationToken) => await Obj.DeleteInstanceRelationAsync(cancellationToken);

		public Stream GetStreamFromInstanceRelation() => Obj.GetStreamFromInstanceRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromInstanceRelationAsync() => await Obj.GetStreamFromInstanceRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromInstanceRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromInstanceRelationAsync(cancellationToken);
    }
}

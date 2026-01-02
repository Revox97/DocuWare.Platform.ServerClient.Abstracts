using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ExtendedUserOperations(SDK.ExtendedUserOperations obj) : IExtendedUserOperations
    {
        internal SDK.ExtendedUserOperations Obj { get; } = obj;

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

		public string PutToReadStatusRelationForString(Stream dataToSend) => Obj.PutToReadStatusRelationForString(dataToSend);

		public async Task<DeserializedHttpResponse<string>> PutToReadStatusRelationForStringAsync(Stream dataToSend) => await Obj.PutToReadStatusRelationForStringAsync(dataToSend);

		public async Task<DeserializedHttpResponse<string>> PutToReadStatusRelationForStringAsync(CancellationToken cancellationToken, Stream dataToSend) => await Obj.PutToReadStatusRelationForStringAsync(cancellationToken, dataToSend);
    }
}

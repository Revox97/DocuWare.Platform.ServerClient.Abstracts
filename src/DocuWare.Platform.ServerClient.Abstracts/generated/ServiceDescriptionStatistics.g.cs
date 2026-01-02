using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ServiceDescriptionStatistics(SDK.ServiceDescriptionStatistics obj) : IServiceDescriptionStatistics
    {
        internal SDK.ServiceDescriptionStatistics Obj { get; } = obj;

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

		public Stream PostToCfsRelationForStream(ICFSStatisticGeneral dataToSend) => Obj.PostToCfsRelationForStream(((CFSStatisticGeneral)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<Stream>> PostToCfsRelationForStreamAsync(ICFSStatisticGeneral dataToSend) => await Obj.PostToCfsRelationForStreamAsync(((CFSStatisticGeneral)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<Stream>> PostToCfsRelationForStreamAsync(CancellationToken cancellationToken, ICFSStatisticGeneral dataToSend) => await Obj.PostToCfsRelationForStreamAsync(cancellationToken, ((CFSStatisticGeneral)dataToSend).Obj);
    }
}

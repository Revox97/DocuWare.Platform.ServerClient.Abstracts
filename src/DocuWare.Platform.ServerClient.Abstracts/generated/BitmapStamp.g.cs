using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BitmapStamp(SDK.BitmapStamp obj) : IBitmapStamp
    {
        internal SDK.BitmapStamp Obj { get; } = obj;

        public string PngData
        {
            get => Obj.PngData;
            set => Obj.PngData = value;
        }

        public float PngWidth
        {
            get => Obj.PngWidth;
            set => Obj.PngWidth = value;
        }

        public float PngHeight
        {
            get => Obj.PngHeight;
            set => Obj.PngHeight = value;
        }

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

		public Stream GetStreamFromContentRelation() => Obj.GetStreamFromContentRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromContentRelationAsync() => await Obj.GetStreamFromContentRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromContentRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromContentRelationAsync(cancellationToken);
    }
}

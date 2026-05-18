using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BitmapStamp(DocuWare.Platform.ServerClient.BitmapStamp obj) : IBitmapStamp
    {
        internal DocuWare.Platform.ServerClient.BitmapStamp Obj { get; } = obj;

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

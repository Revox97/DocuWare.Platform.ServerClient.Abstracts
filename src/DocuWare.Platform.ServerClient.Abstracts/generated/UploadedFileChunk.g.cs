using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class UploadedFileChunk(SDK.UploadedFileChunk obj) : IUploadedFileChunk
    {
        internal SDK.UploadedFileChunk Obj { get; } = obj;

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public bool Finished
        {
            get => Obj.Finished;
            set => Obj.Finished = value;
        }

        public string LastChunkId
        {
            get => Obj.LastChunkId;
            set => Obj.LastChunkId = value;
        }

        public long BytesWritten
        {
            get => Obj.BytesWritten;
            set => Obj.BytesWritten = value;
        }

        public string NextRelationLink => Obj.NextRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public IUploadedFileChunk GetUploadedFileChunkFromNextRelation() => new UploadedFileChunk(Obj.GetUploadedFileChunkFromNextRelation());

        public async Task<DeserializedHttpResponse<IUploadedFileChunk>> GetUploadedFileChunkFromNextRelationAsync()
        {
            DocuWare.Platform.ServerClient.IUploadedFileChunk result = await Obj.GetUploadedFileChunkFromNextRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IUploadedFileChunk(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IUploadedFileChunk>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IUploadedFileChunk>> GetUploadedFileChunkFromNextRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IUploadedFileChunk result = await Obj.GetUploadedFileChunkFromNextRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IUploadedFileChunk(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IUploadedFileChunk>(temp).ConfigureAwait(false);
        }
    }
}

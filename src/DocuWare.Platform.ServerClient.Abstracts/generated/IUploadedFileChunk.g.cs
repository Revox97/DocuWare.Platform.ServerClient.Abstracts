using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IUploadedFileChunk
    {
		Link[] Links { get; set; }
		bool Finished { get; set; }
		string LastChunkId { get; set; }
		long BytesWritten { get; set; }

		void SetProxy(HttpClientProxy proxy);
		IUploadedFileChunk GetUploadedFileChunkFromNextRelation();
		Task<DeserializedHttpResponse<IUploadedFileChunk>> GetUploadedFileChunkFromNextRelationAsync();
		Task<DeserializedHttpResponse<IUploadedFileChunk>> GetUploadedFileChunkFromNextRelationAsync(CancellationToken cancellationToken);
    }
}

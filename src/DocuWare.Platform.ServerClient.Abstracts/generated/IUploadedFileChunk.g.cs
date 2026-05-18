using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

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

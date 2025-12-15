using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IContentMergeOperationInfo
    {
		List<int> Documents { get; set; }
		DocuWare.Platform.ServerClient.ContentMergeOperation Operation { get; set; }
		bool Force { get; set; }
    }
}

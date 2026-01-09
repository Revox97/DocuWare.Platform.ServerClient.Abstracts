using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IContentMergeOperationInfo{3}
    {
		List<int> Documents { get; set; }
		ContentMergeOperation Operation { get; set; }
		bool Force { get; set; }
    }
}

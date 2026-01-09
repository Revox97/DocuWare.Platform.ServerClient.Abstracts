using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IContentDivideOperationInfo
    {
		List<int> Pages { get; set; }
		List<string> ResultNames { get; set; }
		ContentDivideOperation Operation { get; set; }
		bool Force { get; set; }
    }
}

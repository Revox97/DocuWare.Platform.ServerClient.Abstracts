using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFileDownloadBase
    {
		List<int> Layers { get; set; }
		bool KeepAnnotations { get; set; }
    }
}

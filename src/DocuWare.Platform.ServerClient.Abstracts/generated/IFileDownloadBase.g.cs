using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFileDownloadBase{3}
    {
		List<int> Layers { get; set; }
		bool KeepAnnotations { get; set; }
    }
}

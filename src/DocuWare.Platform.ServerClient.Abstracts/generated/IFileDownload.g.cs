using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFileDownload
    {
		FileDownloadType TargetFileType { get; set; }
		bool DirectDownload { get; set; }
		bool AutoPrint { get; set; }
		bool SendByEmail { get; set; }
		bool Fillable { get; set; }
		List<int> Layers { get; set; }
		bool KeepAnnotations { get; set; }
    }
}

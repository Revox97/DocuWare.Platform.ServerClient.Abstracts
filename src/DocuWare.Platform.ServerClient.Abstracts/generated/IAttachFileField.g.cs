using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IAttachFileField : IWebFormField
    {
		string FileTypes { get; set; }
		int MaxFileSize { get; set; }
		int MinFileCount { get; set; }
		int MaxFileCount { get; set; }
		bool ShowFileInfo { get; set; }
		List<IAttachFileInfo> AttachFileInfos { get; set; }
    }
}

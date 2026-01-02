using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IAttachFileField
    {
		List<IAttachFileInfo> AttachFileInfos { get; set; }
    }
}

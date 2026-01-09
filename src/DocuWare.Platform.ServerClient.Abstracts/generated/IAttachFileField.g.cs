using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IAttachFileField: IWebFormField
    {
		List<IAttachFileInfo> AttachFileInfos { get; set; }
    }
}

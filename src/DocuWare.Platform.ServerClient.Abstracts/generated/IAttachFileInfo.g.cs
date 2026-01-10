using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IAttachFileInfo
    {
		string Name { get; set; }
		string FormattedSize { get; set; }
		FileSource Source { get; set; }
    }
}

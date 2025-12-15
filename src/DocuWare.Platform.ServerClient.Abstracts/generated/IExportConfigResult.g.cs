using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IExportConfigResult
    {
		string FileName { get; set; }
		string FileData { get; set; }
    }
}

using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IExportSettings
    {
		bool IncludeDataFiles { get; set; }
		bool ExportHistory { get; set; }
		bool ExportTextshots { get; set; }
    }
}

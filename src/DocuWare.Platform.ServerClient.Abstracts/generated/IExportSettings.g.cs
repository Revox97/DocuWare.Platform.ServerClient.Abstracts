using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IExportSettings{3}
    {
		bool IncludeDataFiles { get; set; }
		bool ExportHistory { get; set; }
		bool ExportTextshots { get; set; }
    }
}

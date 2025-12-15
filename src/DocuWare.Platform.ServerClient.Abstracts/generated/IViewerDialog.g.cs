using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IViewerDialog
    {
		DocuWare.Platform.ServerClient.ViewerDialogModes Mode { get; set; }
		bool MarkFulltextSearchHits { get; set; }
    }
}

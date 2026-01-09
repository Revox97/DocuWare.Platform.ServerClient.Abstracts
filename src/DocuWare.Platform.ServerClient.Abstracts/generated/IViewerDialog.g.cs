using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IViewerDialog
    {
		ViewerDialogModes Mode { get; set; }
		bool MarkFulltextSearchHits { get; set; }
    }
}

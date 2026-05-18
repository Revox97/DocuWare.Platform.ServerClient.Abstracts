using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ViewerDialog(SDK.ViewerDialog obj) : IViewerDialog
    {
        internal SDK.ViewerDialog Obj { get; } = obj;

        public ViewerDialogModes Mode
        {
            get => (ViewerDialogModes)Obj.Mode;
            set => Obj.Mode = (DocuWare.Platform.ServerClient.ViewerDialogModes)value;
        }

        public bool MarkFulltextSearchHits
        {
            get => Obj.MarkFulltextSearchHits;
            set => Obj.MarkFulltextSearchHits = value;
        }
    }
}

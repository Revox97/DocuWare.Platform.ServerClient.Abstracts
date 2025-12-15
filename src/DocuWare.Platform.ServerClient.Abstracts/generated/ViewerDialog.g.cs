using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ViewerDialog(SDK.ViewerDialog obj) : IViewerDialog
    {
        internal SDK.ViewerDialog Obj { get; } = obj;

        public DocuWare.Platform.ServerClient.ViewerDialogModes Mode
        {
            get => Obj.Mode;
            set => Obj.Mode = value;
        }

        public bool MarkFulltextSearchHits
        {
            get => Obj.MarkFulltextSearchHits;
            set => Obj.MarkFulltextSearchHits = value;
        }
    }
}

using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ViewerDialog(DocuWare.Platform.ServerClient.ViewerDialog obj) : IViewerDialog
    {
        internal DocuWare.Platform.ServerClient.ViewerDialog Obj { get; } = obj;

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

using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ViewerDialog(DocuWare.Platform.ServerClient.ViewerDialog obj) : IViewerDialog
    {
        internal DocuWare.Platform.ServerClient.ViewerDialog Obj { get; } = obj;

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

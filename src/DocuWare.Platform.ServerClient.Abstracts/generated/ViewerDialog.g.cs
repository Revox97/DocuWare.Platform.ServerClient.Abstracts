using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ViewerDialog(SDK.ViewerDialog obj) : IViewerDialog
    {
        internal SDK.ViewerDialog Obj { get; } = obj;

		public ViewerDialogModes Mode
		{
			get => new iewerDialogModes(Obj.Mode);
			set => Obj.Mode = ((iewerDialogModes)value).Obj;
		}

		public bool MarkFulltextSearchHits
		{
			get => Obj.MarkFulltextSearchHits;
			set => Obj.MarkFulltextSearchHits = value;
		}
    }
}

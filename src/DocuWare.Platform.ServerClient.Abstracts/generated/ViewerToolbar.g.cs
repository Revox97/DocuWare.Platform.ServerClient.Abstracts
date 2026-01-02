using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ViewerToolbar(DocuWare.Platform.ServerClient.WebClient.ViewerToolbar obj) : IViewerToolbar
    {
        internal DocuWare.Platform.ServerClient.WebClient.ViewerToolbar Obj { get; } = obj;

        public List<IViewerToolbarControl> Controls
        {
            get => Obj.Controls.Select(x => new ViewerToolbarControl(x) as IViewerToolbarControl).ToList();
            set => Obj.Controls = value.Select(x => ((ViewerToolbarControl)x).Obj).ToList();
        }

        public ViewerToolbarType Type
        {
            get => (ViewerToolbarType)Obj.Type;
            set => Obj.Type = (DocuWare.Platform.ServerClient.WebClient.ViewerToolbarType)value;
        }

        public ToolbarPosition Position
        {
            get => (ToolbarPosition)Obj.Position;
            set => Obj.Position = (DocuWare.Platform.ServerClient.WebClient.ToolbarPosition)value;
        }

        public ToolbarVisibility Visibility
        {
            get => (ToolbarVisibility)Obj.Visibility;
            set => Obj.Visibility = (DocuWare.Platform.ServerClient.WebClient.ToolbarVisibility)value;
        }
    }
}

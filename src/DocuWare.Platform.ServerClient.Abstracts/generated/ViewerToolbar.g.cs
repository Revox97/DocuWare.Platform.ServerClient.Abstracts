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

        public DocuWare.Platform.ServerClient.ViewerToolbarType Type
        {
            get => Obj.Type;
            set => Obj.Type = value;
        }

        public DocuWare.Platform.ServerClient.ToolbarPosition Position
        {
            get => Obj.Position;
            set => Obj.Position = value;
        }

        public DocuWare.Platform.ServerClient.ToolbarVisibility Visibility
        {
            get => Obj.Visibility;
            set => Obj.Visibility = value;
        }
    }
}

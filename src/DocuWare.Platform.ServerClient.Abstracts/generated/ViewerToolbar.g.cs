using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ViewerToolbar(SDK.ViewerToolbar obj) : IViewerToolbar
    {
        internal SDK.ViewerToolbar Obj { get; } = obj;

		public List<IViewerToolbarControl> Controls
		{
			get => Obj.Controls.Select(x => new ViewerToolbarControl(x) as IViewerToolbarControl).ToList();
			set => Obj.Controls = value.Select(x => ((ViewerToolbarControl)x).Obj).ToList();
		}

		public ViewerToolbarType Type
		{
			get => new iewerToolbarType(Obj.Type);
			set => Obj.Type = ((iewerToolbarType)value).Obj;
		}

		public ToolbarPosition Position
		{
			get => new oolbarPosition(Obj.Position);
			set => Obj.Position = ((oolbarPosition)value).Obj;
		}

		public ToolbarVisibility Visibility
		{
			get => new oolbarVisibility(Obj.Visibility);
			set => Obj.Visibility = ((oolbarVisibility)value).Obj;
		}
    }
}

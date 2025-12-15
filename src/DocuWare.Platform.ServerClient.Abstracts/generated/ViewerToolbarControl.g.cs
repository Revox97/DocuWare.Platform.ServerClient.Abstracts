using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ViewerToolbarControl(SDK.ViewerToolbarControl obj) : IViewerToolbarControl
    {
        internal SDK.ViewerToolbarControl Obj { get; } = obj;

		public ToolbarControlType Type
		{
			get => new oolbarControlType(Obj.Type);
			set => Obj.Type = ((oolbarControlType)value).Obj;
		}

		public bool Checked
		{
			get => Obj.Checked;
			set => Obj.Checked = value;
		}

		public ToolbarControlState State
		{
			get => new oolbarControlState(Obj.State);
			set => Obj.State = ((oolbarControlState)value).Obj;
		}
    }
}

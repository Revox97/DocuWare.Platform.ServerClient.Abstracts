using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ViewerToolbarControl(SDK.ViewerToolbarControl obj) : IViewerToolbarControl
    {
        internal SDK.ViewerToolbarControl Obj { get; } = obj;

        public DocuWare.Platform.ServerClient.ToolbarControlType Type
        {
            get => Obj.Type;
            set => Obj.Type = value;
        }

        public bool Checked
        {
            get => Obj.Checked;
            set => Obj.Checked = value;
        }

        public DocuWare.Platform.ServerClient.ToolbarControlState State
        {
            get => Obj.State;
            set => Obj.State = value;
        }
    }
}

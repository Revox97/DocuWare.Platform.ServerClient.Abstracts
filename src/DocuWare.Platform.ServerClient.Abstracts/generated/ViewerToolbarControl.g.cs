using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ViewerToolbarControl(DocuWare.Platform.ServerClient.WebClient.ViewerToolbarControl obj) : IViewerToolbarControl
    {
        internal DocuWare.Platform.ServerClient.WebClient.ViewerToolbarControl Obj { get; } = obj;

        public ToolbarControlType Type
        {
            get => (ToolbarControlType)Obj.Type;
            set => Obj.Type = (DocuWare.Platform.ServerClient.WebClient.ToolbarControlType)value;
        }

        public bool Checked
        {
            get => Obj.Checked;
            set => Obj.Checked = value;
        }

        public ToolbarControlState State
        {
            get => (ToolbarControlState)Obj.State;
            set => Obj.State = (DocuWare.Platform.ServerClient.WebClient.ToolbarControlState)value;
        }
    }
}

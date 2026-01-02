using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ViewerPreferences(DocuWare.Platform.ServerClient.WebClient.ViewerPreferences obj) : IViewerPreferences
    {
        internal DocuWare.Platform.ServerClient.WebClient.ViewerPreferences Obj { get; } = obj;

        public List<IAnnotationToolSettings> Annotations
        {
            get => Obj.Annotations.Select(x => new AnnotationToolSettings(x) as IAnnotationToolSettings).ToList();
            set => Obj.Annotations = value.Select(x => ((AnnotationToolSettings)x).Obj).ToList();
        }

        public List<IViewerToolbar> Toolbars
        {
            get => Obj.Toolbars.Select(x => new ViewerToolbar(x) as IViewerToolbar).ToList();
            set => Obj.Toolbars = value.Select(x => ((ViewerToolbar)x).Obj).ToList();
        }

        public string Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }

        public ToolbarVisibility LeftToolbarState
        {
            get => (ToolbarVisibility)Obj.LeftToolbarState;
            set => Obj.LeftToolbarState = (DocuWare.Platform.ServerClient.WebClient.ToolbarVisibility)value;
        }

        public ToolbarVisibility RightToolbarState
        {
            get => (ToolbarVisibility)Obj.RightToolbarState;
            set => Obj.RightToolbarState = (DocuWare.Platform.ServerClient.WebClient.ToolbarVisibility)value;
        }

        public bool ExpandStatusbar
        {
            get => Obj.ExpandStatusbar;
            set => Obj.ExpandStatusbar = value;
        }
    }
}

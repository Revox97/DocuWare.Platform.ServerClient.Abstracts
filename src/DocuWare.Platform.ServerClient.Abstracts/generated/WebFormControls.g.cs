using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WebFormControls(SDK.WebFormControls obj) : IWebFormControls
    {
        internal SDK.WebFormControls Obj { get; } = obj;

        public List<IWebFormControl> WebFormControl
        {
            get => Obj.WebFormControl.Select(x => new WebFormControl(x) as IWebFormControl).ToList();
            set => Obj.WebFormControl = value.Select(x => ((WebFormControl)x).Obj).ToList();
        }
    }
}

using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WebFormControls(DocuWare.Platform.ServerClient.WebFormControls obj) : IWebFormControls
    {
        internal DocuWare.Platform.ServerClient.WebFormControls Obj { get; } = obj;

        public List<IWebFormControl> WebFormControl
        {
            get => Obj.WebFormControl.Select(x => new Abstracts.IWebFormFieldWebFormField(x) as WebFormControl).ToList();
            set => Obj.WebFormControl = value.Select(x => ((WebFormControl)x).Obj).ToList();
        }
    }
}

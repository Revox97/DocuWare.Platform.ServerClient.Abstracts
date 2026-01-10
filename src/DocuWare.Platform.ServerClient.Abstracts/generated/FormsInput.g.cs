using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FormsInput(DocuWare.Platform.ServerClient.FormsInput obj) : IFormsInput
    {
        internal DocuWare.Platform.ServerClient.FormsInput Obj { get; } = obj;

        public IFormInfo FormInfo
        {
            get => new FormInfo(Obj.FormInfo);
            set => Obj.FormInfo = ((FormInfo)value).Obj;
        }

        public string HTML
        {
            get => Obj.HTML;
            set => Obj.HTML = value;
        }
    }
}

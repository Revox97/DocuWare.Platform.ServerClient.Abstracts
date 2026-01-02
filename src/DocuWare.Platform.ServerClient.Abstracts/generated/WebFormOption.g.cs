using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WebFormOption(DocuWare.Platform.ServerClient.WebFormOption obj) : IWebFormOption
    {
        internal DocuWare.Platform.ServerClient.WebFormOption Obj { get; } = obj;

        public string Label
        {
            get => Obj.Label;
            set => Obj.Label = value;
        }

        public bool Checked
        {
            get => Obj.Checked;
            set => Obj.Checked = value;
        }
    }
}

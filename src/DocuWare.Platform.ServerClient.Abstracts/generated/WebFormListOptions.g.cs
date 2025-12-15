using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WebFormListOptions(SDK.WebFormListOptions obj) : IWebFormListOptions
    {
        internal SDK.WebFormListOptions Obj { get; } = obj;

        public List<string> WebFormListOption
        {
            get => Obj.WebFormListOption;
            set => Obj.WebFormListOption = value;
        }
    }
}

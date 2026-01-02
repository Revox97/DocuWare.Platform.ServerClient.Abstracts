using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WebFormListOptions(DocuWare.Platform.ServerClient.WebFormListOptions obj) : IWebFormListOptions
    {
        internal DocuWare.Platform.ServerClient.WebFormListOptions Obj { get; } = obj;

        public List<string> WebFormListOption
        {
            get => Obj.WebFormListOption;
            set => Obj.WebFormListOption = value;
        }
    }
}

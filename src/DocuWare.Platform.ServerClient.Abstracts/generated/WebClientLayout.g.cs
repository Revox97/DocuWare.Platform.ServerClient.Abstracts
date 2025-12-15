using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WebClientLayout(SDK.WebClientLayout obj) : IWebClientLayout
    {
        internal SDK.WebClientLayout Obj { get; } = obj;

        public DocuWare.Platform.ServerClient.LayoutMode Mode
        {
            get => Obj.Mode;
            set => Obj.Mode = value;
        }
    }
}

using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WebClientLayout(DocuWare.Platform.ServerClient.WebClient.WebClientLayout obj) : IWebClientLayout
    {
        internal DocuWare.Platform.ServerClient.WebClient.WebClientLayout Obj { get; } = obj;

        public LayoutMode Mode
        {
            get => (LayoutMode)Obj.Mode;
            set => Obj.Mode = (DocuWare.Platform.ServerClient.WebClient.LayoutMode)value;
        }
    }
}

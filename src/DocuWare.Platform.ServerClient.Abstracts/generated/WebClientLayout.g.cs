using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WebClientLayout(SDK.WebClientLayout obj) : IWebClientLayout
    {
        internal SDK.WebClientLayout Obj { get; } = obj;

		public LayoutMode Mode
		{
			get => new ayoutMode(Obj.Mode);
			set => Obj.Mode = ((ayoutMode)value).Obj;
		}
    }
}

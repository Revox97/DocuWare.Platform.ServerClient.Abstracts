using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WebSettings(SDK.WebSettings obj) : IWebSettings
    {
        internal SDK.WebSettings Obj { get; } = obj;

		public List<IApplicationPreferences> ApplicationPreferences
		{
			get => Obj.ApplicationPreferences.Select(x => new ApplicationPreferences(x) as IApplicationPreferences).ToList();
			set => Obj.ApplicationPreferences = value.Select(x => ((ApplicationPreferences)x).Obj).ToList();
		}
    }
}

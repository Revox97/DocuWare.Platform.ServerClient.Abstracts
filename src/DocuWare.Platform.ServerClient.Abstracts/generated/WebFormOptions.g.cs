using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WebFormOptions(SDK.WebFormOptions obj) : IWebFormOptions
    {
        internal SDK.WebFormOptions Obj { get; } = obj;

		public List<IWebFormOption> WebFormOption
		{
			get => Obj.WebFormOption.Select(x => new WebFormOption(x) as IWebFormOption).ToList();
			set => Obj.WebFormOption = value.Select(x => ((WebFormOption)x).Obj).ToList();
		}
    }
}

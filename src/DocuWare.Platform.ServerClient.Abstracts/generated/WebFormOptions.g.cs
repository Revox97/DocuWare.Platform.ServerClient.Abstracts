using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WebFormOptions(DocuWare.Platform.ServerClient.WebFormOptions obj) : IWebFormOptions
    {
        internal DocuWare.Platform.ServerClient.WebFormOptions Obj { get; } = obj;

        public List<IWebFormOption> WebFormOption
        {
            get => Obj.WebFormOption.Select(x => new WebFormOption(x) as IWebFormOption).ToList();
            set => Obj.WebFormOption = value.Select(x => ((WebFormOption)x).Obj).ToList();
        }
    }
}

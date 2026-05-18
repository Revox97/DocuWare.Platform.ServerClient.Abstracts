using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

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

using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Sections(SDK.Sections obj) : ISections
    {
        internal SDK.Sections Obj { get; } = obj;

        public List<ISection> Section
        {
            get => Obj.Section.Select(x => new Section(x) as ISection).ToList();
            set => Obj.Section = value.Select(x => ((Section)x).Obj).ToList();
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}

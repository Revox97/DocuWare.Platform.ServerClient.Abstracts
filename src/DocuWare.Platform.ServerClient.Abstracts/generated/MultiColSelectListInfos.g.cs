using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class MultiColSelectListInfos(SDK.MultiColSelectListInfos obj) : IMultiColSelectListInfos
    {
        internal SDK.MultiColSelectListInfos Obj { get; } = obj;

        public List<IMultiColSelectListInfo> MultiColSelectLists
        {
            get => Obj.MultiColSelectLists.Select(x => new MultiColSelectListInfo(x) as IMultiColSelectListInfo).ToList();
            set => Obj.MultiColSelectLists = value.Select(x => ((MultiColSelectListInfo)x).Obj).ToList();
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}

using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SubstitutionLists(SDK.SubstitutionLists obj) : ISubstitutionLists
    {
        internal SDK.SubstitutionLists Obj { get; } = obj;

        public List<ISubstitutionList> Item
        {
            get => Obj.Item.Select(x => new SubstitutionList(x) as ISubstitutionList).ToList();
            set => Obj.Item = value.Select(x => ((SubstitutionList)x).Obj).ToList();
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}

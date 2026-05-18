using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Roles(SDK.Roles obj) : IRoles
    {
        internal SDK.Roles Obj { get; } = obj;

        public List<IRole> Item
        {
            get => Obj.Item.Select(x => new Role(x) as IRole).ToList();
            set => Obj.Item = value.Select(x => ((Role)x).Obj).ToList();
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}

using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DesignerInstances(SDK.DesignerInstances obj) : IDesignerInstances
    {
        internal SDK.DesignerInstances Obj { get; } = obj;

        public List<IDesignerInstance> DesignerInstance
        {
            get => Obj.DesignerInstance.Select(x => new DesignerInstance(x) as IDesignerInstance).ToList();
            set => Obj.DesignerInstance = value.Select(x => ((DesignerInstance)x).Obj).ToList();
        }

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}

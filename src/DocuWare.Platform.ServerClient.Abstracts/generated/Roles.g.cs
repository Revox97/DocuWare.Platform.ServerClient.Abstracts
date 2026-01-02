using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Roles(DocuWare.Platform.ServerClient.Roles obj) : IRoles
    {
        internal DocuWare.Platform.ServerClient.Roles Obj { get; } = obj;

        public List<IRole> Item
        {
            get => Obj.Item.Select(x => new Role(x) as IRole).ToList();
            set => Obj.Item = value.Select(x => ((Role)x).Obj).ToList();
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}

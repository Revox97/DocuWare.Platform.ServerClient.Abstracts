using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Groups(DocuWare.Platform.ServerClient.Groups obj) : IGroups
    {
        internal DocuWare.Platform.ServerClient.Groups Obj { get; } = obj;

        public List<IGroup> Item
        {
            get => Obj.Item.Select(x => new Group(x) as IGroup).ToList();
            set => Obj.Item = value.Select(x => ((Group)x).Obj).ToList();
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}

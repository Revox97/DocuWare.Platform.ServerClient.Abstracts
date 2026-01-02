using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Stamps(DocuWare.Platform.ServerClient.Stamps obj) : IStamps
    {
        internal DocuWare.Platform.ServerClient.Stamps Obj { get; } = obj;

        public List<IStamp> Stamp
        {
            get => Obj.Stamp.Select(x => new Stamp(x) as IStamp).ToList();
            set => Obj.Stamp = value.Select(x => ((Stamp)x).Obj).ToList();
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}

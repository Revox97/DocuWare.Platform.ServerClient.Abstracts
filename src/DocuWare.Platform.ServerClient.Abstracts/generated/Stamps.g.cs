using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Stamps(SDK.Stamps obj) : IStamps
    {
        internal SDK.Stamps Obj { get; } = obj;

        public List<IStamp> Stamp
        {
            get => Obj.Stamp.Select(x => new Stamp(x) as IStamp).ToList();
            set => Obj.Stamp = value.Select(x => ((Stamp)x).Obj).ToList();
        }

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}

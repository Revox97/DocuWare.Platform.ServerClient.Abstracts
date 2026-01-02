using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SelectListInfos(SDK.SelectListInfos obj) : ISelectListInfos
    {
        internal SDK.SelectListInfos Obj { get; } = obj;

        public List<ISelectListInfo> SelectLists
        {
            get => Obj.SelectLists.Select(x => new SelectListInfo(x) as ISelectListInfo).ToList();
            set => Obj.SelectLists = value.Select(x => ((SelectListInfo)x).Obj).ToList();
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}

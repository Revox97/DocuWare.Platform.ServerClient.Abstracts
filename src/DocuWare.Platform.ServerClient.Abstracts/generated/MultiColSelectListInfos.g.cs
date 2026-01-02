using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class MultiColSelectListInfos(DocuWare.Platform.ServerClient.MultiColSelectListInfos obj) : IMultiColSelectListInfos
    {
        internal DocuWare.Platform.ServerClient.MultiColSelectListInfos Obj { get; } = obj;

        public List<IMultiColSelectListInfo> MultiColSelectLists
        {
            get => Obj.MultiColSelectLists.Select(x => new MultiColSelectListInfo(x) as IMultiColSelectListInfo).ToList();
            set => Obj.MultiColSelectLists = value.Select(x => ((MultiColSelectListInfo)x).Obj).ToList();
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}

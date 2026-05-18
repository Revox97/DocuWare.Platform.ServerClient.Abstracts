using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class HistoryInstances(DocuWare.Platform.ServerClient.HistoryInstances obj) : IHistoryInstances
    {
        internal DocuWare.Platform.ServerClient.HistoryInstances Obj { get; } = obj;

        public List<IHistoryInstance> HistoryInstance
        {
            get => Obj.HistoryInstance.Select(x => new HistoryInstance(x) as IHistoryInstance).ToList();
            set => Obj.HistoryInstance = value.Select(x => ((HistoryInstance)x).Obj).ToList();
        }

        public int Count
        {
            get => Obj.Count;
            set => Obj.Count = value;
        }

        public DateTime TimeStamp
        {
            get => Obj.TimeStamp;
            set => Obj.TimeStamp = value;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}

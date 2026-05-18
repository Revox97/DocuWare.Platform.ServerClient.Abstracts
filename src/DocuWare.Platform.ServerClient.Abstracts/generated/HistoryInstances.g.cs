using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class HistoryInstances(SDK.HistoryInstances obj) : IHistoryInstances
    {
        internal SDK.HistoryInstances Obj { get; } = obj;

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

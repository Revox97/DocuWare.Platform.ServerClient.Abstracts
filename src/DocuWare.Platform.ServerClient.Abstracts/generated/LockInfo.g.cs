using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class LockInfo(SDK.LockInfo obj) : ILockInfo
    {
        internal SDK.LockInfo Obj { get; } = obj;

        public string Interval
        {
            get => Obj.Interval;
            set => Obj.Interval = value;
        }

        public string Operation
        {
            get => Obj.Operation;
            set => Obj.Operation = value;
        }
    }
}

using SDK = DocuWare.Platform.ServerClient;

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

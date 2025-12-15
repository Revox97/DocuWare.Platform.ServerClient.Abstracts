using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class HistoryStepInfo(SDK.HistoryStepInfo obj) : IHistoryStepInfo
    {
        internal SDK.HistoryStepInfo Obj { get; } = obj;

        public object Item
        {
            get => Obj.Item;
            set => Obj.Item = value;
        }
    }
}

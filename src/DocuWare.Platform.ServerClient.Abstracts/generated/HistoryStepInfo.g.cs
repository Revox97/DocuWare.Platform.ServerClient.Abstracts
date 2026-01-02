using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class HistoryStepInfo(DocuWare.Platform.ServerClient.HistoryStepInfo obj) : IHistoryStepInfo
    {
        internal DocuWare.Platform.ServerClient.HistoryStepInfo Obj { get; } = obj;

        public object Item
        {
            get => Obj.Item;
            set => Obj.Item = value;
        }
    }
}

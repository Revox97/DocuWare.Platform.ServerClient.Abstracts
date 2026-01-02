using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class HistoryStepInfoBase(DocuWare.Platform.ServerClient.HistoryStepInfoBase obj) : IHistoryStepInfoBase
    {
        internal DocuWare.Platform.ServerClient.HistoryStepInfoBase Obj { get; } = obj;

        public object Item
        {
            get => Obj.Item;
            set => Obj.Item = value;
        }
    }
}

using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class HistoryFieldOptions(SDK.HistoryFieldOptions obj) : IHistoryFieldOptions
    {
        internal SDK.HistoryFieldOptions Obj { get; } = obj;

        public object Item
        {
            get => Obj.Item;
            set => Obj.Item = value;
        }
    }
}

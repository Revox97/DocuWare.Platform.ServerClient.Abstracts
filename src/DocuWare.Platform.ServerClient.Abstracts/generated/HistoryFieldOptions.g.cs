using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class HistoryFieldOptions(DocuWare.Platform.ServerClient.HistoryFieldOptions obj) : IHistoryFieldOptions
    {
        internal DocuWare.Platform.ServerClient.HistoryFieldOptions Obj { get; } = obj;

        public object Item
        {
            get => Obj.Item;
            set => Obj.Item = value;
        }
    }
}

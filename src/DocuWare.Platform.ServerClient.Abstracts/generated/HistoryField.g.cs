using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class HistoryField(SDK.HistoryField obj) : IHistoryField
    {
        internal SDK.HistoryField Obj { get; } = obj;

        public string Label
        {
            get => Obj.Label;
            set => Obj.Label = value;
        }

        public DocuWare.Platform.ServerClient.HistoryFormTypeEnum Type
        {
            get => Obj.Type;
            set => Obj.Type = value;
        }
    }
}

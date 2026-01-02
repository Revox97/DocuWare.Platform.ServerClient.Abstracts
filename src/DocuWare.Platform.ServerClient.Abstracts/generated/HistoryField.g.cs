using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class HistoryField(DocuWare.Platform.ServerClient.HistoryField obj) : IHistoryField
    {
        internal DocuWare.Platform.ServerClient.HistoryField Obj { get; } = obj;

        public string Label
        {
            get => Obj.Label;
            set => Obj.Label = value;
        }

        public HistoryFormTypeEnum Type
        {
            get => (HistoryFormTypeEnum)Obj.Type;
            set => Obj.Type = (DocuWare.Platform.ServerClient.HistoryFormTypeEnum)value;
        }
    }
}

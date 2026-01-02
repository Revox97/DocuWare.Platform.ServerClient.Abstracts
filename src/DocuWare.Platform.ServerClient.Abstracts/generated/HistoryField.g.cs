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

        public DocuWare.Platform.ServerClient.HistoryFormTypeEnum Type
        {
            get => Obj.Type;
            set => Obj.Type = value;
        }
    }
}

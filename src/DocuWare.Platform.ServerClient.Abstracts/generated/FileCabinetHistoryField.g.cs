using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FileCabinetHistoryField(DocuWare.Platform.ServerClient.FileCabinetHistoryField obj) : IFileCabinetHistoryField
    {
        internal DocuWare.Platform.ServerClient.FileCabinetHistoryField Obj { get; } = obj;

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

using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FileCabinetHistoryField(SDK.FileCabinetHistoryField obj) : IFileCabinetHistoryField
    {
        internal SDK.FileCabinetHistoryField Obj { get; } = obj;

        public string FileCabinetName
        {
            get => Obj.FileCabinetName;
            set => Obj.FileCabinetName = value;
        }

        public string DocId
        {
            get => Obj.DocId;
            set => Obj.DocId = value;
        }

        public IWFFormFieldValue Value
        {
            get => new WFFormFieldValue(Obj.Value);
            set => Obj.Value = ((WFFormFieldValue)value).Obj;
        }

        public IHistoryFieldOptions Options
        {
            get => new HistoryFieldOptions(Obj.Options);
            set => Obj.Options = ((HistoryFieldOptions)value).Obj;
        }

        public DocuWare.Platform.ServerClient.AssignmentType AssignmentType
        {
            get => Obj.AssignmentType;
            set => Obj.AssignmentType = value;
        }

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

using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FileCabinetHistoryField(DocuWare.Platform.ServerClient.FileCabinetHistoryField obj) : IFileCabinetHistoryField
    {
        internal DocuWare.Platform.ServerClient.FileCabinetHistoryField Obj { get; } = obj;

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

        public AssignmentType AssignmentType
        {
            get => (AssignmentType)Obj.AssignmentType;
            set => Obj.AssignmentType = (DocuWare.Platform.ServerClient.AssignmentType)value;
        }

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

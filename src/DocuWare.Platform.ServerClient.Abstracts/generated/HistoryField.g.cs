using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class HistoryField(DocuWare.Platform.ServerClient.HistoryField obj) : IHistoryField
    {
        internal DocuWare.Platform.ServerClient.HistoryField Obj { get; } = obj;

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

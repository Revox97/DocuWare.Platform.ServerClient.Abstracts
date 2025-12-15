using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class HistoryField(SDK.HistoryField obj) : IHistoryField
    {
        internal SDK.HistoryField Obj { get; } = obj;

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

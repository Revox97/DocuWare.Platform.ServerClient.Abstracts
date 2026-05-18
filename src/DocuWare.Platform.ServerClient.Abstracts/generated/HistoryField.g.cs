using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

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

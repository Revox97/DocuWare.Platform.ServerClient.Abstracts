using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class StampFormFieldValues(SDK.StampFormFieldValues obj) : IStampFormFieldValues
    {
        internal SDK.StampFormFieldValues Obj { get; } = obj;

        public List<IFormFieldValue> Field
        {
            get => Obj.Field.Select(x => new FormFieldValue(x) as IFormFieldValue).ToList();
            set => Obj.Field = value.Select(x => ((FormFieldValue)x).Obj).ToList();
        }

        public string StampId
        {
            get => Obj.StampId;
            set => Obj.StampId = value;
        }
    }
}

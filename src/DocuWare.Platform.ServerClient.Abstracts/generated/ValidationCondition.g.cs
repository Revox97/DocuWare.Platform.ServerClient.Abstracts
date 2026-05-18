using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ValidationCondition(SDK.ValidationCondition obj) : IValidationCondition
    {
        internal SDK.ValidationCondition Obj { get; } = obj;

        public ComparisonType ComparisonType
        {
            get => (ComparisonType)Obj.ComparisonType;
            set => Obj.ComparisonType = (DocuWare.Platform.ServerClient.ComparisonType)value;
        }

        public string FieldID
        {
            get => Obj.FieldID;
            set => Obj.FieldID = value;
        }

        public Operator Operator
        {
            get => (Operator)Obj.Operator;
            set => Obj.Operator = (DocuWare.Platform.ServerClient.Operator)value;
        }

        public string Value
        {
            get => Obj.Value;
            set => Obj.Value = value;
        }

        public Continuation Continuation
        {
            get => (Continuation)Obj.Continuation;
            set => Obj.Continuation = (DocuWare.Platform.ServerClient.Continuation)value;
        }
    }
}

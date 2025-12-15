using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ValidationCondition(SDK.ValidationCondition obj) : IValidationCondition
    {
        internal SDK.ValidationCondition Obj { get; } = obj;

        public DocuWare.Platform.ServerClient.ComparisonType ComparisonType
        {
            get => Obj.ComparisonType;
            set => Obj.ComparisonType = value;
        }

        public string FieldID
        {
            get => Obj.FieldID;
            set => Obj.FieldID = value;
        }

        public DocuWare.Platform.ServerClient.Operator Operator
        {
            get => Obj.Operator;
            set => Obj.Operator = value;
        }

        public string Value
        {
            get => Obj.Value;
            set => Obj.Value = value;
        }

        public DocuWare.Platform.ServerClient.Continuation Continuation
        {
            get => Obj.Continuation;
            set => Obj.Continuation = value;
        }
    }
}

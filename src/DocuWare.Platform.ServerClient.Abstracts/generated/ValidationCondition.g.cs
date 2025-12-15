using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ValidationCondition(SDK.ValidationCondition obj) : IValidationCondition
    {
        internal SDK.ValidationCondition Obj { get; } = obj;

		public ComparisonType ComparisonType
		{
			get => new omparisonType(Obj.ComparisonType);
			set => Obj.ComparisonType = ((omparisonType)value).Obj;
		}

		public string FieldID
		{
			get => Obj.FieldID;
			set => Obj.FieldID = value;
		}

		public Operator Operator
		{
			get => new perator(Obj.Operator);
			set => Obj.Operator = ((perator)value).Obj;
		}

		public string Value
		{
			get => Obj.Value;
			set => Obj.Value = value;
		}

		public Continuation Continuation
		{
			get => new ontinuation(Obj.Continuation);
			set => Obj.Continuation = ((ontinuation)value).Obj;
		}
    }
}

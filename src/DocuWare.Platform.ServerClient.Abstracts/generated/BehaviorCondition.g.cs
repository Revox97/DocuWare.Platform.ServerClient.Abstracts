using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BehaviorCondition(SDK.BehaviorCondition obj) : IBehaviorCondition
    {
        internal SDK.BehaviorCondition Obj { get; } = obj;

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

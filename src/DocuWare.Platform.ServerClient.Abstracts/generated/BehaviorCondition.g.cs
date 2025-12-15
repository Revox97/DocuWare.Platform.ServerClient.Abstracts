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

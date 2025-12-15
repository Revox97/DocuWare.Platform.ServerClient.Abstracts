using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DecisionFormFieldValue(SDK.DecisionFormFieldValue obj) : IDecisionFormFieldValue
    {
        internal SDK.DecisionFormFieldValue Obj { get; } = obj;

        public int Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }

        public IDocumentIndexFieldValue TypedValue
        {
            get => new DocumentIndexFieldValue(Obj.TypedValue);
            set => Obj.TypedValue = ((DocumentIndexFieldValue)value).Obj;
        }

        public string Name
        {
            get => Obj.Name;
            set => Obj.Name = value;
        }

        public string Value
        {
            get => Obj.Value;
            set => Obj.Value = value;
        }
    }
}

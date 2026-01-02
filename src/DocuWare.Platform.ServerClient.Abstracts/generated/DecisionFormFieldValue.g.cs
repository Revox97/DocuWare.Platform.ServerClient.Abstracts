using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DecisionFormFieldValue(DocuWare.Platform.ServerClient.DecisionFormFieldValue obj) : IDecisionFormFieldValue
    {
        internal DocuWare.Platform.ServerClient.DecisionFormFieldValue Obj { get; } = obj;

        public int Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
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

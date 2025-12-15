using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FormFieldValue(SDK.FormFieldValue obj) : IFormFieldValue
    {
        internal SDK.FormFieldValue Obj { get; } = obj;

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

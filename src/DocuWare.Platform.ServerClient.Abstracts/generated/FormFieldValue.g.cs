using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FormFieldValue(DocuWare.Platform.ServerClient.FormFieldValue obj) : IFormFieldValue
    {
        internal DocuWare.Platform.ServerClient.FormFieldValue Obj { get; } = obj;

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

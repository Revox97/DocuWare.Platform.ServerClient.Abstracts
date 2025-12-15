using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FormFieldValues(SDK.FormFieldValues obj) : IFormFieldValues
    {
        internal SDK.FormFieldValues Obj { get; } = obj;

        public List<IFormFieldValue> Field
        {
            get => Obj.Field.Select(x => new FormFieldValue(x) as IFormFieldValue).ToList();
            set => Obj.Field = value.Select(x => ((FormFieldValue)x).Obj).ToList();
        }
    }
}

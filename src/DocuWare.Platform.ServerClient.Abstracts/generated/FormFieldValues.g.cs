using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FormFieldValues(DocuWare.Platform.ServerClient.FormFieldValues obj) : IFormFieldValues
    {
        internal DocuWare.Platform.ServerClient.FormFieldValues Obj { get; } = obj;

        public List<IFormFieldValue> Field
        {
            get => Obj.Field.Select(x => new FormFieldValue(x) as IFormFieldValue).ToList();
            set => Obj.Field = value.Select(x => ((FormFieldValue)x).Obj).ToList();
        }
    }
}

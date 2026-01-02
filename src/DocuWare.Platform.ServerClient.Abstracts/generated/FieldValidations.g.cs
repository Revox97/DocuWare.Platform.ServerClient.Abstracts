using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FieldValidations(DocuWare.Platform.ServerClient.FieldValidations obj) : IFieldValidations
    {
        internal DocuWare.Platform.ServerClient.FieldValidations Obj { get; } = obj;

        public List<ICustomFieldValidation> FieldValidation
        {
            get => Obj.FieldValidation.Select(x => new CustomFieldValidation(x) as ICustomFieldValidation).ToList();
            set => Obj.FieldValidation = value.Select(x => ((CustomFieldValidation)x).Obj).ToList();
        }
    }
}

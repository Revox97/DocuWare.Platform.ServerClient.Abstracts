using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class CustomFieldValidation(DocuWare.Platform.ServerClient.CustomFieldValidation obj) : ICustomFieldValidation
    {
        internal DocuWare.Platform.ServerClient.CustomFieldValidation Obj { get; } = obj;

        public List<IValidationCondition> Conditions
        {
            get => Obj.Conditions.Select(x => new ValidationCondition(x) as IValidationCondition).ToList();
            set => Obj.Conditions = value.Select(x => ((ValidationCondition)x).Obj).ToList();
        }
    }
}

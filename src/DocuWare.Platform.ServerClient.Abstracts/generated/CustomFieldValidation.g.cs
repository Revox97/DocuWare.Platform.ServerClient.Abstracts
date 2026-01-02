using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class CustomFieldValidation(SDK.CustomFieldValidation obj) : ICustomFieldValidation
    {
        internal SDK.CustomFieldValidation Obj { get; } = obj;

        public List<IValidationCondition> Conditions
        {
            get => Obj.Conditions.Select(x => new ValidationCondition(x) as IValidationCondition).ToList();
            set => Obj.Conditions = value.Select(x => ((ValidationCondition)x).Obj).ToList();
        }
    }
}

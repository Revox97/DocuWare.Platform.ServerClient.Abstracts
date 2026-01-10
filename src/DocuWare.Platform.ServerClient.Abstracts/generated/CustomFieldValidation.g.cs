using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class CustomFieldValidation(DocuWare.Platform.ServerClient.CustomFieldValidation obj) : ICustomFieldValidation
    {
        internal DocuWare.Platform.ServerClient.CustomFieldValidation Obj { get; } = obj;

        public string FieldType
        {
            get => Obj.FieldType;
            set => Obj.FieldType = value;
        }

        public List<IValidationCondition> Conditions
        {
            get => Obj.Conditions.Select(x => new ValidationCondition(x) as IValidationCondition).ToList();
            set => Obj.Conditions = value.Select(x => ((ValidationCondition)x).Obj).ToList();
        }

        public string Name
        {
            get => Obj.Name;
            set => Obj.Name = value;
        }

        public string Description
        {
            get => Obj.Description;
            set => Obj.Description = value;
        }

        public string FieldValidationID
        {
            get => Obj.FieldValidationID;
            set => Obj.FieldValidationID = value;
        }

        public string ErrorMessage
        {
            get => Obj.ErrorMessage;
            set => Obj.ErrorMessage = value;
        }
    }
}

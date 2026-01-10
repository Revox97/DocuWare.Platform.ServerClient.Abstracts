using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ICustomFieldValidation
    {
		string FieldType { get; set; }
		List<IValidationCondition> Conditions { get; set; }
		string Name { get; set; }
		string Description { get; set; }
		string FieldValidationID { get; set; }
		string ErrorMessage { get; set; }
    }
}

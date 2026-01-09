using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ICustomFieldValidation
    {
		List<IValidationCondition> Conditions { get; set; }
    }
}

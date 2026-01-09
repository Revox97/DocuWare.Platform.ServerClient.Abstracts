using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ICustomFieldValidation{3}
    {
		List<IValidationCondition> Conditions { get; set; }
    }
}

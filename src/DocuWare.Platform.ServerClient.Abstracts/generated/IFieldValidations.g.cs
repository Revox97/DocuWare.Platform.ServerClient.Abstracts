using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFieldValidations
    {
		List<ICustomFieldValidation> FieldValidation { get; set; }
    }
}

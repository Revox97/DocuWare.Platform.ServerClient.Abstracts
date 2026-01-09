using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFormInfo{3}
    {
		List<IWebFormControl> Fields { get; set; }
		List<IBehavior> Behaviors { get; set; }
		List<ICustomFieldValidation> FieldValidations { get; set; }
		bool Public { get; set; }
    }
}

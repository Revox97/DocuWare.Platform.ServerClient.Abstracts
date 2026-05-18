using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFormInfo
    {
		string ConfigId { get; set; }
		string Name { get; set; }
		List<IWebFormControl> Fields { get; set; }
		List<IBehavior> Behaviors { get; set; }
		List<ICustomFieldValidation> FieldValidations { get; set; }
		IFormProperties FormProperties { get; set; }
		ISubmissionOptions SubmissionOptions { get; set; }
		bool Public { get; set; }
    }
}

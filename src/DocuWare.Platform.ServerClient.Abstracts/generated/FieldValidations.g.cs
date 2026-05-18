using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FieldValidations(SDK.FieldValidations obj) : IFieldValidations
    {
        internal SDK.FieldValidations Obj { get; } = obj;

        public List<ICustomFieldValidation> FieldValidation
        {
            get => Obj.FieldValidation.Select(x => new CustomFieldValidation(x) as ICustomFieldValidation).ToList();
            set => Obj.FieldValidation = value.Select(x => ((CustomFieldValidation)x).Obj).ToList();
        }
    }
}

using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FormTemplates(SDK.FormTemplates obj) : IFormTemplates
    {
        internal SDK.FormTemplates Obj { get; } = obj;

        public List<IFormTemplate> Template
        {
            get => Obj.Template.Select(x => new FormTemplate(x) as IFormTemplate).ToList();
            set => Obj.Template = value.Select(x => ((FormTemplate)x).Obj).ToList();
        }
    }
}

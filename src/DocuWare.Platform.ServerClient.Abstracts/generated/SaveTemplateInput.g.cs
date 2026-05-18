using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SaveTemplateInput(SDK.SaveTemplateInput obj) : ISaveTemplateInput
    {
        internal SDK.SaveTemplateInput Obj { get; } = obj;

        public List<IFormTemplate> Templates
        {
            get => Obj.Templates.Select(x => new FormTemplate(x) as IFormTemplate).ToList();
            set => Obj.Templates = value.Select(x => ((FormTemplate)x).Obj).ToList();
        }
    }
}

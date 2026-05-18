using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DeleteTemplatesInput(SDK.DeleteTemplatesInput obj) : IDeleteTemplatesInput
    {
        internal SDK.DeleteTemplatesInput Obj { get; } = obj;

        public List<string> TemplateGUIDS
        {
            get => Obj.TemplateGUIDS;
            set => Obj.TemplateGUIDS = value;
        }
    }
}

using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FormsInput(SDK.FormsInput obj) : IFormsInput
    {
        internal SDK.FormsInput Obj { get; } = obj;

        public IFormInfo FormInfo
        {
            get => new FormInfo(Obj.FormInfo);
            set => Obj.FormInfo = ((FormInfo)value).Obj;
        }

        public string HTML
        {
            get => Obj.HTML;
            set => Obj.HTML = value;
        }
    }
}

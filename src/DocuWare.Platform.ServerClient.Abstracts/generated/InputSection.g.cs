using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class InputSection(SDK.InputSection obj) : IInputSection
    {
        internal SDK.InputSection Obj { get; } = obj;

        public List<IApplicationProperty> ApplicationProperties
        {
            get => Obj.ApplicationProperties.Select(x => new ApplicationProperty(x) as IApplicationProperty).ToList();
            set => Obj.ApplicationProperties = value.Select(x => ((ApplicationProperty)x).Obj).ToList();
        }
    }
}

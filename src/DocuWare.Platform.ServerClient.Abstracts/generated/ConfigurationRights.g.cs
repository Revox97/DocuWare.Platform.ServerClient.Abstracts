using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ConfigurationRights(SDK.ConfigurationRights obj) : IConfigurationRights
    {
        internal SDK.ConfigurationRights Obj { get; } = obj;

        public List<ConfigurationRight> ConfigurationRight
        {
            get => Obj.ConfigurationRight.ConvertAll(o => (ConfigurationRight)o);
            set => Obj.ConfigurationRight = value.ConvertAll(v => (DocuWare.Platform.ServerClient.ConfigurationRight)v);
        }
    }
}

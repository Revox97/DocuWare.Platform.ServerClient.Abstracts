using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts.WebClient
{
    public class MultiFCSearches(SDK.WebClient.MultiFCSearches obj) : IMultiFCSearches
    {
        internal SDK.WebClient.MultiFCSearches Obj { get; } = obj;

        public List<IMultiFCSearchConfiguration> Configurations
        {
            get => Obj.Configurations.Select(x => new MultiFCSearchConfiguration(x) as IMultiFCSearchConfiguration).ToList();
            set => Obj.Configurations = value.Select(x => ((MultiFCSearchConfiguration)x).Obj).ToList();
        }

        public bool _ignore_me
        {
            get => Obj._ignore_me;
            set => Obj._ignore_me = value;
        }
    }
}

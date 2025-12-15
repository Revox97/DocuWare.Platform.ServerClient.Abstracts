using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class MultiFCSearches(SDK.MultiFCSearches obj) : IMultiFCSearches
    {
        internal SDK.MultiFCSearches Obj { get; } = obj;

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

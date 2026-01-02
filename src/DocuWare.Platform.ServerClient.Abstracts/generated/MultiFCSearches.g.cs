using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class MultiFCSearches(DocuWare.Platform.ServerClient.WebClient.MultiFCSearches obj) : IMultiFCSearches
    {
        internal DocuWare.Platform.ServerClient.WebClient.MultiFCSearches Obj { get; } = obj;

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

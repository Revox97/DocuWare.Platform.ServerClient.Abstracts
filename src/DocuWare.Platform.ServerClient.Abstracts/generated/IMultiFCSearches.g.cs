using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IMultiFCSearches
    {
		List<IMultiFCSearchConfiguration> Configurations { get; set; }
		bool _ignore_me { get; set; }
    }
}

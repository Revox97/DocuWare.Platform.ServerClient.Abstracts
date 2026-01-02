using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IConfigurationRights
    {
		List<ConfigurationRight> ConfigurationRight { get; set; }
    }
}

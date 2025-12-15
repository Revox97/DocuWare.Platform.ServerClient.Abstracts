using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IConfigurationRights
    {
		List<DocuWare.Platform.ServerClient.ConfigurationRight> ConfigurationRight { get; set; }
    }
}

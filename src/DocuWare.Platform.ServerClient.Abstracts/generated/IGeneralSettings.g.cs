using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IGeneralSettings
    {
		WorkAreaType StartWith { get; set; }
		string CreatedVersion { get; set; }
    }
}

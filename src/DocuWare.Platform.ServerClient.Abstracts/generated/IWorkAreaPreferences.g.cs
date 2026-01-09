using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IWorkAreaPreferences
    {
		List<IContentAreaPreferences> ContentAreas { get; set; }
		string Name { get; set; }
    }
}

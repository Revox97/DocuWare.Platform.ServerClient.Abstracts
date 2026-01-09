using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IWorkAreaPreferences{3}
    {
		List<IContentAreaPreferences> ContentAreas { get; set; }
		string Name { get; set; }
    }
}

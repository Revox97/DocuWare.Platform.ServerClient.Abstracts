using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IContentAreaPreferences
    {
		List<IWorkInstance> Instances { get; set; }
		WorkAreaType AreaType { get; set; }
		int SelectedInstanceIndex { get; set; }
    }
}

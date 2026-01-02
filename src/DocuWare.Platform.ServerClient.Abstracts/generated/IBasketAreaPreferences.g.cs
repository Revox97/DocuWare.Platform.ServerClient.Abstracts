using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IBasketAreaPreferences
    {
		bool StoreDialogsBarLocked { get; set; }
		List<IWorkInstance> Instances { get; set; }
		DocuWare.Platform.ServerClient.WorkAreaType AreaType { get; set; }
		int SelectedInstanceIndex { get; set; }
    }
}

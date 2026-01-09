using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IBasketAreaPreferences : IContentAreaPreferences
    {
		bool StoreDialogsBarLocked { get; set; }
    }
}

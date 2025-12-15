using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFavorites
    {
		IFavoriteItems Baskets { get; set; }
		IFavoriteItems StoreDialogs { get; set; }
		IFavoriteItems SearchDialogs { get; set; }
		IFavoriteItems TaskLists { get; set; }
		IFavoriteItems TreeViews { get; set; }
		IFavoriteItems MultiFCSearches { get; set; }
		IFavoriteItems Forms { get; set; }
    }
}

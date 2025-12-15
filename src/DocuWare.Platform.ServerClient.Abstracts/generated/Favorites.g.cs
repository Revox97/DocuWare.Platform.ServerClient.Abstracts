using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Favorites(SDK.Favorites obj) : IFavorites
    {
        internal SDK.Favorites Obj { get; } = obj;

		public IFavoriteItems Baskets
		{
			get => new FavoriteItems(Obj.Baskets);
			set => Obj.Baskets = ((FavoriteItems)value).Obj;
		}

		public IFavoriteItems StoreDialogs
		{
			get => new FavoriteItems(Obj.StoreDialogs);
			set => Obj.StoreDialogs = ((FavoriteItems)value).Obj;
		}

		public IFavoriteItems SearchDialogs
		{
			get => new FavoriteItems(Obj.SearchDialogs);
			set => Obj.SearchDialogs = ((FavoriteItems)value).Obj;
		}

		public IFavoriteItems TaskLists
		{
			get => new FavoriteItems(Obj.TaskLists);
			set => Obj.TaskLists = ((FavoriteItems)value).Obj;
		}

		public IFavoriteItems TreeViews
		{
			get => new FavoriteItems(Obj.TreeViews);
			set => Obj.TreeViews = ((FavoriteItems)value).Obj;
		}

		public IFavoriteItems MultiFCSearches
		{
			get => new FavoriteItems(Obj.MultiFCSearches);
			set => Obj.MultiFCSearches = ((FavoriteItems)value).Obj;
		}

		public IFavoriteItems Forms
		{
			get => new FavoriteItems(Obj.Forms);
			set => Obj.Forms = ((FavoriteItems)value).Obj;
		}
    }
}

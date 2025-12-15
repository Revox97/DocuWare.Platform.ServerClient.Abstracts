using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FavoriteItems(SDK.FavoriteItems obj) : IFavoriteItems
    {
        internal SDK.FavoriteItems Obj { get; } = obj;

		public List<string> Disabled
		{
			get => Obj.Disabled;
			set => Obj.Disabled = value;
		}

		public List<string> Order
		{
			get => Obj.Order;
			set => Obj.Order = value;
		}
    }
}

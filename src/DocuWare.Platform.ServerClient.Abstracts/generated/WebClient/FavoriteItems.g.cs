using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts.WebClient
{
    public class FavoriteItems(SDK.WebClient.FavoriteItems obj) : IFavoriteItems
    {
        internal SDK.WebClient.FavoriteItems Obj { get; } = obj;

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

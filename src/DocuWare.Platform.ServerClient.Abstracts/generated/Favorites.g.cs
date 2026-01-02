using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Favorites(SDK.Favorites obj) : IFavorites
    {
        internal SDK.Favorites Obj { get; } = obj;
    }
}

using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Favorites(DocuWare.Platform.ServerClient.WebClient.Favorites obj) : IFavorites
    {
        internal DocuWare.Platform.ServerClient.WebClient.Favorites Obj { get; } = obj;
    }
}

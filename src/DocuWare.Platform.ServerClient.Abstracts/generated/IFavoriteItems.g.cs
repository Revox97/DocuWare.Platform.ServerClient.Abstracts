using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFavoriteItems
    {
		List<string> Disabled { get; set; }
		List<string> Order { get; set; }
    }
}

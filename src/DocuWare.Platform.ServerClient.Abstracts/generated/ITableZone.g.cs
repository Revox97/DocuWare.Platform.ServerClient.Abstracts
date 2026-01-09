using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITableZone : IRectangleBase
    {
		List<ICellZone> Cz { get; set; }
    }
}

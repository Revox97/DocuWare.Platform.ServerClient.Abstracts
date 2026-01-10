using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITableZone : IRectangleBase
    {
		IgridTable gridT { get; set; }
		List<ICellZone> Cz { get; set; }
    }
}

using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IBarCodeZone : IRectangleBase
    {
		string BarcodeType { get; set; }
    }
}

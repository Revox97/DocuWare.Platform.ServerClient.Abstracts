using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IBarCodeZone : IRectangleBase
    {
		string Value { get; set; }
		string BarcodeType { get; set; }
    }
}

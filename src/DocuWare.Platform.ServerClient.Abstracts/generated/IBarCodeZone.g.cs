using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IBarCodeZone
    {
		string Value { get; set; }
		string BarcodeType { get; set; }
		int L { get; set; }
		int T { get; set; }
		int W { get; set; }
		int H { get; set; }
    }
}

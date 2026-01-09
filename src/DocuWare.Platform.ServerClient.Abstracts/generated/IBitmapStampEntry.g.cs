using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IBitmapStampEntry : IStampBase
    {
		Byte[] PngData { get; set; }
		int DpiX { get; set; }
		int DpiY { get; set; }
    }
}

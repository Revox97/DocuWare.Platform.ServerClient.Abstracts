using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IPageContent
    {
		List<IRectangleBase> Items { get; set; }
		List<IBarCodeZone> BarCodes { get; set; }
		List<IKeyValuePair> metadata { get; set; }
		List<ICandidateInfo> Candidates { get; set; }
		string Lang { get; set; }
		DocuWare.Platform.ServerClient.LanguageDetection LanguageDetection { get; set; }
		int CandidateDetectionVersion { get; set; }
		int Version { get; set; }
		double HorizontalDpi { get; set; }
		double VerticalDpi { get; set; }
		int SizeX { get; set; }
		int SizeY { get; set; }
		double SkewAngle { get; set; }
		DocuWare.Platform.ServerClient.Rotation Rotation { get; set; }
		string FileTag { get; set; }
    }
}

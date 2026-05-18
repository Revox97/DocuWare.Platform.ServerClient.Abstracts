using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts.Content
{
    public interface IPageContent
    {
		List<IRectangleBase> Items { get; set; }
		List<IBarCodeZone> BarCodes { get; set; }
		List<IKeyValuePair> metadata { get; set; }
		List<ICandidateInfo> Candidates { get; set; }
		string Lang { get; set; }
		LanguageDetection LanguageDetection { get; set; }
		int CandidateDetectionVersion { get; set; }
		int Version { get; set; }
		double HorizontalDpi { get; set; }
		double VerticalDpi { get; set; }
		int SizeX { get; set; }
		int SizeY { get; set; }
		double SkewAngle { get; set; }
		Rotation Rotation { get; set; }
		string FileTag { get; set; }
    }
}

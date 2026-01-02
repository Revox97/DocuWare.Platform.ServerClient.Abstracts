using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITextStampEntry
    {
		DocuWare.Platform.ServerClient.StampSignatureType Signature { get; set; }
		string UserName { get; set; }
		bool Visible { get; set; }
		bool Frame { get; set; }
		bool ShowUser { get; set; }
		bool ShowDate { get; set; }
		bool ShowTime { get; set; }
		string SigScopeInfo { get; set; }
		string Type { get; set; }
		string Color { get; set; }
		int Rotation { get; set; }
		bool Transparent { get; set; }
		int StrokeWidth { get; set; }
		string Id { get; set; }
    }
}

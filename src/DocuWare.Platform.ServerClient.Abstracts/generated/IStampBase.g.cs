using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IStampBase : IEntryBase
    {
		StampSignatureType Signature { get; set; }
		string UserName { get; set; }
		bool Visible { get; set; }
		bool Frame { get; set; }
		bool ShowUser { get; set; }
		bool ShowDate { get; set; }
		bool ShowTime { get; set; }
		string SigScopeInfo { get; set; }
    }
}

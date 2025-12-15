using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISubmissionOptions
    {
		string SubmissionMessage { get; set; }
		string RedirectUrl { get; set; }
		bool ShowReturnToForm { get; set; }
		bool ShowLinkToStoredDocument { get; set; }
		bool Redirect { get; set; }
		bool RedirectImmediately { get; set; }
		int RedirectDelaySeconds { get; set; }
		DocuWare.Platform.ServerClient.RedirectType RedirectType { get; set; }
		bool ShowSubmissionMessage { get; set; }
    }
}

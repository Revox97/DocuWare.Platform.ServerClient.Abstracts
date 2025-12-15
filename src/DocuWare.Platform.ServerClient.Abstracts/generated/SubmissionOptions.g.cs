using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SubmissionOptions(SDK.SubmissionOptions obj) : ISubmissionOptions
    {
        internal SDK.SubmissionOptions Obj { get; } = obj;

		public string SubmissionMessage
		{
			get => Obj.SubmissionMessage;
			set => Obj.SubmissionMessage = value;
		}

		public string RedirectUrl
		{
			get => Obj.RedirectUrl;
			set => Obj.RedirectUrl = value;
		}

		public bool ShowReturnToForm
		{
			get => Obj.ShowReturnToForm;
			set => Obj.ShowReturnToForm = value;
		}

		public bool ShowLinkToStoredDocument
		{
			get => Obj.ShowLinkToStoredDocument;
			set => Obj.ShowLinkToStoredDocument = value;
		}

		public bool Redirect
		{
			get => Obj.Redirect;
			set => Obj.Redirect = value;
		}

		public bool RedirectImmediately
		{
			get => Obj.RedirectImmediately;
			set => Obj.RedirectImmediately = value;
		}

		public int RedirectDelaySeconds
		{
			get => Obj.RedirectDelaySeconds;
			set => Obj.RedirectDelaySeconds = value;
		}

		public RedirectType RedirectType
		{
			get => new edirectType(Obj.RedirectType);
			set => Obj.RedirectType = ((edirectType)value).Obj;
		}

		public bool ShowSubmissionMessage
		{
			get => Obj.ShowSubmissionMessage;
			set => Obj.ShowSubmissionMessage = value;
		}
    }
}

using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FileDownloadPage(SDK.FileDownloadPage obj) : IFileDownloadPage
    {
        internal SDK.FileDownloadPage Obj { get; } = obj;

		public bool AutoPrint
		{
			get => Obj.AutoPrint;
			set => Obj.AutoPrint = value;
		}

		public bool SendByEmail
		{
			get => Obj.SendByEmail;
			set => Obj.SendByEmail = value;
		}

		public List<int> Layers
		{
			get => Obj.Layers;
			set => Obj.Layers = value;
		}

		public bool KeepAnnotations
		{
			get => Obj.KeepAnnotations;
			set => Obj.KeepAnnotations = value;
		}
    }
}

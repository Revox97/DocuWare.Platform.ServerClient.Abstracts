using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ExportConfigResult(SDK.ExportConfigResult obj) : IExportConfigResult
    {
        internal SDK.ExportConfigResult Obj { get; } = obj;

		public string FileName
		{
			get => Obj.FileName;
			set => Obj.FileName = value;
		}

		public string FileData
		{
			get => Obj.FileData;
			set => Obj.FileData = value;
		}
    }
}

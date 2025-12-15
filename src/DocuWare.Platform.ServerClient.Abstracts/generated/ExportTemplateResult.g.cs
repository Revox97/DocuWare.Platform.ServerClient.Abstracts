using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ExportTemplateResult(SDK.ExportTemplateResult obj) : IExportTemplateResult
    {
        internal SDK.ExportTemplateResult Obj { get; } = obj;

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

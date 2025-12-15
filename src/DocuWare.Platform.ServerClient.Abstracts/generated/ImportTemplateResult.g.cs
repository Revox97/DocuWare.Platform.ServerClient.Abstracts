using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ImportTemplateResult(SDK.ImportTemplateResult obj) : IImportTemplateResult
    {
        internal SDK.ImportTemplateResult Obj { get; } = obj;

		public string ConfigJSON
		{
			get => Obj.ConfigJSON;
			set => Obj.ConfigJSON = value;
		}
    }
}

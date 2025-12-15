using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ImportConfigResult(SDK.ImportConfigResult obj) : IImportConfigResult
    {
        internal SDK.ImportConfigResult Obj { get; } = obj;

		public string ConfigJSON
		{
			get => Obj.ConfigJSON;
			set => Obj.ConfigJSON = value;
		}
    }
}

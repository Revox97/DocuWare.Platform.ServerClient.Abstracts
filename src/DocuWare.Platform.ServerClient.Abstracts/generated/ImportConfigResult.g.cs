using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ImportConfigResult(DocuWare.Platform.ServerClient.ImportConfigResult obj) : IImportConfigResult
    {
        internal DocuWare.Platform.ServerClient.ImportConfigResult Obj { get; } = obj;

        public string ConfigJSON
        {
            get => Obj.ConfigJSON;
            set => Obj.ConfigJSON = value;
        }
    }
}

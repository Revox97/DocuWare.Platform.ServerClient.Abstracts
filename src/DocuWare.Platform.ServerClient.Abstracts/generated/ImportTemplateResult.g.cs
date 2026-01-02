using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ImportTemplateResult(DocuWare.Platform.ServerClient.ImportTemplateResult obj) : IImportTemplateResult
    {
        internal DocuWare.Platform.ServerClient.ImportTemplateResult Obj { get; } = obj;

        public string ConfigJSON
        {
            get => Obj.ConfigJSON;
            set => Obj.ConfigJSON = value;
        }
    }
}

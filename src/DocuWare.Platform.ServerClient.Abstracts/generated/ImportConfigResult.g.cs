using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

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

using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ExportConfigInput(SDK.ExportConfigInput obj) : IExportConfigInput
    {
        internal SDK.ExportConfigInput Obj { get; } = obj;

        public string ConfigGUID
        {
            get => Obj.ConfigGUID;
            set => Obj.ConfigGUID = value;
        }

        public string OrganizationID
        {
            get => Obj.OrganizationID;
            set => Obj.OrganizationID = value;
        }
    }
}

using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts.WebClient
{
    public class GeneralSettings(SDK.WebClient.GeneralSettings obj) : IGeneralSettings
    {
        internal SDK.WebClient.GeneralSettings Obj { get; } = obj;

        public WorkAreaType StartWith
        {
            get => (WorkAreaType)Obj.StartWith;
            set => Obj.StartWith = (DocuWare.Platform.ServerClient.WebClient.WorkAreaType)value;
        }

        public string CreatedVersion
        {
            get => Obj.CreatedVersion;
            set => Obj.CreatedVersion = value;
        }

        public bool DefaultLYClient
        {
            get => Obj.DefaultLYClient;
            set => Obj.DefaultLYClient = value;
        }
    }
}

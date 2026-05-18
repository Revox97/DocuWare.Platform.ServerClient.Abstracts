using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ExtendedConfigurationRights(SDK.ExtendedConfigurationRights obj) : IExtendedConfigurationRights
    {
        internal SDK.ExtendedConfigurationRights Obj { get; } = obj;

        public bool Forms
        {
            get => Obj.Forms;
            set => Obj.Forms = value;
        }

        public bool IntelligentInsights
        {
            get => Obj.IntelligentInsights;
            set => Obj.IntelligentInsights = value;
        }

        public bool EInvoicingConnector
        {
            get => Obj.EInvoicingConnector;
            set => Obj.EInvoicingConnector = value;
        }

        public bool EInvoicingService
        {
            get => Obj.EInvoicingService;
            set => Obj.EInvoicingService = value;
        }

        public bool ConfigureIDP
        {
            get => Obj.ConfigureIDP;
            set => Obj.ConfigureIDP = value;
        }
    }
}

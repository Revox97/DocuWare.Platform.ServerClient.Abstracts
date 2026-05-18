using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ExtendedConfigurationRights(DocuWare.Platform.ServerClient.ExtendedConfigurationRights obj) : IExtendedConfigurationRights
    {
        internal DocuWare.Platform.ServerClient.ExtendedConfigurationRights Obj { get; } = obj;

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

using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class XmlDSigContentType(SDK.XmlDSigContentType obj) : IXmlDSigContentType
    {
        internal SDK.XmlDSigContentType Obj { get; } = obj;

        public List<IXmlDSigContentType> Nodes
        {
            get => Obj.Nodes.Select(x => new XmlDSigContentType(x) as IXmlDSigContentType).ToList();
            set => Obj.Nodes = value.Select(x => ((XmlDSigContentType)x).Obj).ToList();
        }

        public XmlDSigStatusType Status
        {
            get => (XmlDSigStatusType)Obj.Status;
            set => Obj.Status = (DocuWare.Platform.ServerClient.XmlDSigStatusType)value;
        }

        public string Description
        {
            get => Obj.Description;
            set => Obj.Description = value;
        }

        public string ErrorInfo
        {
            get => Obj.ErrorInfo;
            set => Obj.ErrorInfo = value;
        }

        public bool Warning
        {
            get => Obj.Warning;
            set => Obj.Warning = value;
        }
    }
}

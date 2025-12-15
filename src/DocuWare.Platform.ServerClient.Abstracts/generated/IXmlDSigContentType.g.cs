using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IXmlDSigContentType
    {
		List<IXmlDSigContentType> Nodes { get; set; }
		DocuWare.Platform.ServerClient.XmlDSigStatusType Status { get; set; }
		string Description { get; set; }
		string ErrorInfo { get; set; }
		bool Warning { get; set; }
    }
}

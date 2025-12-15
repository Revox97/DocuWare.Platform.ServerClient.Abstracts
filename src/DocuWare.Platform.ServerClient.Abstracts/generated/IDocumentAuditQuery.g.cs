using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentAuditQuery
    {
		int Start { get; set; }
		int Count { get; set; }
		DateTime FromDate { get; set; }
		bool FromDateSpecified { get; set; }
		DateTime ToDate { get; set; }
		bool ToDateSpecified { get; set; }
    }
}

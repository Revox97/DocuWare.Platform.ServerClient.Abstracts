using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ICheckInActionParameters
    {
		IDocumentVersion DocumentVersion { get; set; }
		DocuWare.Platform.ServerClient.CheckInReturnDocument CheckInReturnDocument { get; set; }
		string Comments { get; set; }
    }
}

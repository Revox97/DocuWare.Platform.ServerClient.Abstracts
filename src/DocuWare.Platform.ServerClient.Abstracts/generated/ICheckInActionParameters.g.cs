using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ICheckInActionParameters
    {
		IDocumentVersion DocumentVersion { get; set; }
		CheckInReturnDocument CheckInReturnDocument { get; set; }
		string Comments { get; set; }
    }
}

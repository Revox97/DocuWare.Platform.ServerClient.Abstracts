using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ICheckInActionParameters : IDocumentActionParameters
    {
		string MediaType { get; }
		IDocumentVersion DocumentVersion { get; set; }
		CheckInReturnDocument CheckInReturnDocument { get; set; }
		string Comments { get; set; }
    }
}

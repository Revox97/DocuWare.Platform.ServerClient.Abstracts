using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ICheckInActionParameters : IDocumentActionParameters
    {
		CheckInReturnDocument CheckInReturnDocument { get; set; }
		string Comments { get; set; }
    }
}

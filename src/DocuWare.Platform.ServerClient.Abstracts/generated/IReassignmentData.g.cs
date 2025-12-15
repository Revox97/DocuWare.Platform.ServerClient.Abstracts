using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IReassignmentData
    {
		List<IAssignedItem> ReassignmentList { get; set; }
		string Subject { get; set; }
		string Body { get; set; }
		bool SendEmail { get; set; }
    }
}

using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IAssignToHistoryStep
    {
		List<string> AssignedUsers { get; set; }
    }
}

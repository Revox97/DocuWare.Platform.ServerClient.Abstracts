using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IRequestDataDecision
    {
		string UserName { get; set; }
		string DecisionName { get; set; }
		string Comment { get; set; }
    }
}

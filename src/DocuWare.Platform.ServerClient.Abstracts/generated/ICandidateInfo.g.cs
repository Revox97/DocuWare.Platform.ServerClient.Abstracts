using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ICandidateInfo
    {
		string Type { get; set; }
		List<ICandidate> Candidates { get; set; }
    }
}

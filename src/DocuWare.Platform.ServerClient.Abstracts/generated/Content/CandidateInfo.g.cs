using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts.Content
{
    public class CandidateInfo(SDK.Content.CandidateInfo obj) : ICandidateInfo
    {
        internal SDK.Content.CandidateInfo Obj { get; } = obj;

        public string Type
        {
            get => Obj.Type;
            set => Obj.Type = value;
        }

        public List<ICandidate> Candidates
        {
            get => Obj.Candidates.Select(x => new Candidate(x) as ICandidate).ToList();
            set => Obj.Candidates = value.Select(x => ((Candidate)x).Obj).ToList();
        }
    }
}

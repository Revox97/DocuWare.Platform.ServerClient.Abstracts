using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class CandidateInfo(DocuWare.Platform.ServerClient.Content.CandidateInfo obj) : ICandidateInfo
    {
        internal DocuWare.Platform.ServerClient.Content.CandidateInfo Obj { get; } = obj;

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

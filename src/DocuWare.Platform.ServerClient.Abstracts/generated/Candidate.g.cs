using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Candidate(SDK.Candidate obj) : ICandidate
    {
        internal SDK.Candidate Obj { get; } = obj;

        public object Item
        {
            get => Obj.Item;
            set => Obj.Item = value;
        }

        public List<string> FoundWithLanguages
        {
            get => Obj.FoundWithLanguages;
            set => Obj.FoundWithLanguages = value;
        }

        public List<string> CorrectLanguageTo
        {
            get => Obj.CorrectLanguageTo;
            set => Obj.CorrectLanguageTo = value;
        }

        public List<string> ImpliesCultures
        {
            get => Obj.ImpliesCultures;
            set => Obj.ImpliesCultures = value;
        }
    }
}

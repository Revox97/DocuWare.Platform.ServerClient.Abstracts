using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Candidate(SDK.Candidate obj) : ICandidate
    {
        internal SDK.Candidate Obj { get; } = obj;

		public string Type
		{
			get => Obj.Type;
			set => Obj.Type = value;
		}

		public string OriginalValue
		{
			get => Obj.OriginalValue;
			set => Obj.OriginalValue = value;
		}

		public string FoundValue
		{
			get => Obj.FoundValue;
			set => Obj.FoundValue = value;
		}

		public int L
		{
			get => Obj.L;
			set => Obj.L = value;
		}

		public int T
		{
			get => Obj.T;
			set => Obj.T = value;
		}

		public int W
		{
			get => Obj.W;
			set => Obj.W = value;
		}

		public int H
		{
			get => Obj.H;
			set => Obj.H = value;
		}

		public int Line
		{
			get => Obj.Line;
			set => Obj.Line = value;
		}

		public int Index
		{
			get => Obj.Index;
			set => Obj.Index = value;
		}

		public int Length
		{
			get => Obj.Length;
			set => Obj.Length = value;
		}

		public Object Item
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

using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class PageContent(SDK.PageContent obj) : IPageContent
    {
        internal SDK.PageContent Obj { get; } = obj;

		public List<IRectangleBase> Items
		{
			get => Obj.Items.Select(x => new RectangleBase(x) as IRectangleBase).ToList();
			set => Obj.Items = value.Select(x => ((RectangleBase)x).Obj).ToList();
		}

		public List<IBarCodeZone> BarCodes
		{
			get => Obj.BarCodes.Select(x => new BarCodeZone(x) as IBarCodeZone).ToList();
			set => Obj.BarCodes = value.Select(x => ((BarCodeZone)x).Obj).ToList();
		}

		public List<IKeyValuePair> metadata
		{
			get => Obj.metadata.Select(x => new KeyValuePair(x) as IKeyValuePair).ToList();
			set => Obj.metadata = value.Select(x => ((KeyValuePair)x).Obj).ToList();
		}

		public List<ICandidateInfo> Candidates
		{
			get => Obj.Candidates.Select(x => new CandidateInfo(x) as ICandidateInfo).ToList();
			set => Obj.Candidates = value.Select(x => ((CandidateInfo)x).Obj).ToList();
		}

		public string Lang
		{
			get => Obj.Lang;
			set => Obj.Lang = value;
		}

		public LanguageDetection LanguageDetection
		{
			get => new anguageDetection(Obj.LanguageDetection);
			set => Obj.LanguageDetection = ((anguageDetection)value).Obj;
		}

		public int CandidateDetectionVersion
		{
			get => Obj.CandidateDetectionVersion;
			set => Obj.CandidateDetectionVersion = value;
		}

		public int Version
		{
			get => Obj.Version;
			set => Obj.Version = value;
		}

		public double HorizontalDpi
		{
			get => Obj.HorizontalDpi;
			set => Obj.HorizontalDpi = value;
		}

		public double VerticalDpi
		{
			get => Obj.VerticalDpi;
			set => Obj.VerticalDpi = value;
		}

		public int SizeX
		{
			get => Obj.SizeX;
			set => Obj.SizeX = value;
		}

		public int SizeY
		{
			get => Obj.SizeY;
			set => Obj.SizeY = value;
		}

		public double SkewAngle
		{
			get => Obj.SkewAngle;
			set => Obj.SkewAngle = value;
		}

		public Rotation Rotation
		{
			get => new otation(Obj.Rotation);
			set => Obj.Rotation = ((otation)value).Obj;
		}

		public string FileTag
		{
			get => Obj.FileTag;
			set => Obj.FileTag = value;
		}
    }
}

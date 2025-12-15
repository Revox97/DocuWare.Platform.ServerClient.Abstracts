using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class PolyLineStampEntry(SDK.PolyLineStampEntry obj) : IPolyLineStampEntry
    {
        internal SDK.PolyLineStampEntry Obj { get; } = obj;

		public List<IStroke> Stroke
		{
			get => Obj.Stroke.Select(x => new Stroke(x) as IStroke).ToList();
			set => Obj.Stroke = value.Select(x => ((Stroke)x).Obj).ToList();
		}

		public IAnnotationRectangle Location
		{
			get => new AnnotationRectangle(Obj.Location);
			set => Obj.Location = ((AnnotationRectangle)value).Obj;
		}

		public IFont HeadFont
		{
			get => new Font(Obj.HeadFont);
			set => Obj.HeadFont = ((Font)value).Obj;
		}

		public StampSignatureType Signature
		{
			get => new tampSignatureType(Obj.Signature);
			set => Obj.Signature = ((tampSignatureType)value).Obj;
		}

		public string UserName
		{
			get => Obj.UserName;
			set => Obj.UserName = value;
		}

		public bool Visible
		{
			get => Obj.Visible;
			set => Obj.Visible = value;
		}

		public bool Frame
		{
			get => Obj.Frame;
			set => Obj.Frame = value;
		}

		public bool ShowUser
		{
			get => Obj.ShowUser;
			set => Obj.ShowUser = value;
		}

		public bool ShowDate
		{
			get => Obj.ShowDate;
			set => Obj.ShowDate = value;
		}

		public bool ShowTime
		{
			get => Obj.ShowTime;
			set => Obj.ShowTime = value;
		}

		public string SigScopeInfo
		{
			get => Obj.SigScopeInfo;
			set => Obj.SigScopeInfo = value;
		}

		public ICreatedInfo Created
		{
			get => new CreatedInfo(Obj.Created);
			set => Obj.Created = ((CreatedInfo)value).Obj;
		}

		public string Type
		{
			get => Obj.Type;
			set => Obj.Type = value;
		}

		public string Color
		{
			get => Obj.Color;
			set => Obj.Color = value;
		}

		public int Rotation
		{
			get => Obj.Rotation;
			set => Obj.Rotation = value;
		}

		public bool Transparent
		{
			get => Obj.Transparent;
			set => Obj.Transparent = value;
		}

		public int StrokeWidth
		{
			get => Obj.StrokeWidth;
			set => Obj.StrokeWidth = value;
		}

		public string Id
		{
			get => Obj.Id;
			set => Obj.Id = value;
		}
    }
}

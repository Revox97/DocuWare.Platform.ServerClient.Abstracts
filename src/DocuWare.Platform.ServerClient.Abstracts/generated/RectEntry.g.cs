using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class RectEntry(SDK.RectEntry obj) : IRectEntry
    {
        internal SDK.RectEntry Obj { get; } = obj;

		public IAnnotationRectangle Location
		{
			get => new AnnotationRectangle(Obj.Location);
			set => Obj.Location = ((AnnotationRectangle)value).Obj;
		}

		public bool Filled
		{
			get => Obj.Filled;
			set => Obj.Filled = value;
		}

		public bool Ellipse
		{
			get => Obj.Ellipse;
			set => Obj.Ellipse = value;
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

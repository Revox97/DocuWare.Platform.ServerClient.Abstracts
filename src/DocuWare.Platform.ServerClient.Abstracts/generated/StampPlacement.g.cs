using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class StampPlacement(SDK.StampPlacement obj) : IStampPlacement
    {
        internal SDK.StampPlacement Obj { get; } = obj;

		public IPolyLineEntry Strokes
		{
			get => new PolyLineEntry(Obj.Strokes);
			set => Obj.Strokes = ((PolyLineEntry)value).Obj;
		}

		public IDWPoint Location
		{
			get => new DWPoint(Obj.Location);
			set => Obj.Location = ((DWPoint)value).Obj;
		}

		public List<IFormFieldValue> Field
		{
			get => Obj.Field.Select(x => new FormFieldValue(x) as IFormFieldValue).ToList();
			set => Obj.Field = value.Select(x => ((FormFieldValue)x).Obj).ToList();
		}

		public string StampId
		{
			get => Obj.StampId;
			set => Obj.StampId = value;
		}

		public int Rotation
		{
			get => Obj.Rotation;
			set => Obj.Rotation = value;
		}

		public int Layer
		{
			get => Obj.Layer;
			set => Obj.Layer = value;
		}

		public string Password
		{
			get => Obj.Password;
			set => Obj.Password = value;
		}
    }
}

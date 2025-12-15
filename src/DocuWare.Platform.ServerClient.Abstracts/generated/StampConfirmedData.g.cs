using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class StampConfirmedData(SDK.StampConfirmedData obj) : IStampConfirmedData
    {
        internal SDK.StampConfirmedData Obj { get; } = obj;

		public IAnnotationPoint Position
		{
			get => new AnnotationPoint(Obj.Position);
			set => Obj.Position = ((AnnotationPoint)value).Obj;
		}

		public int Section
		{
			get => Obj.Section;
			set => Obj.Section = value;
		}

		public int Page
		{
			get => Obj.Page;
			set => Obj.Page = value;
		}

		public int Layer
		{
			get => Obj.Layer;
			set => Obj.Layer = value;
		}

		public List<IConfirmedField> ConfirmedFields
		{
			get => Obj.ConfirmedFields.Select(x => new ConfirmedField(x) as IConfirmedField).ToList();
			set => Obj.ConfirmedFields = value.Select(x => ((ConfirmedField)x).Obj).ToList();
		}
    }
}

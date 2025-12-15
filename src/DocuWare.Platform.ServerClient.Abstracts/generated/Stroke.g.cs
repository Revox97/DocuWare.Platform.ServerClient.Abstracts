using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Stroke(SDK.Stroke obj) : IStroke
    {
        internal SDK.Stroke Obj { get; } = obj;

		public List<IAnnotationPoint> Point
		{
			get => Obj.Point.Select(x => new AnnotationPoint(x) as IAnnotationPoint).ToList();
			set => Obj.Point = value.Select(x => ((AnnotationPoint)x).Obj).ToList();
		}

		public bool _do_not_use
		{
			get => Obj._do_not_use;
			set => Obj._do_not_use = value;
		}
    }
}

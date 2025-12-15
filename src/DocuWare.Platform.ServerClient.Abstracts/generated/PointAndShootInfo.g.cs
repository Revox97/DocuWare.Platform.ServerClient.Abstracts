using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class PointAndShootInfo(SDK.PointAndShootInfo obj) : IPointAndShootInfo
    {
        internal SDK.PointAndShootInfo Obj { get; } = obj;

		public List<IDWRectangle> Box
		{
			get => Obj.Box.Select(x => new DWRectangle(x) as IDWRectangle).ToList();
			set => Obj.Box = value.Select(x => ((DWRectangle)x).Obj).ToList();
		}

		public int PageNumber
		{
			get => Obj.PageNumber;
			set => Obj.PageNumber = value;
		}
    }
}

using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class PointAndShootInfo(DocuWare.Platform.ServerClient.PointAndShootInfo obj) : IPointAndShootInfo
    {
        internal DocuWare.Platform.ServerClient.PointAndShootInfo Obj { get; } = obj;

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

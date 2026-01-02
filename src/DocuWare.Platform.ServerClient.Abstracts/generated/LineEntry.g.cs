using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class LineEntry(DocuWare.Platform.ServerClient.LineEntry obj) : ILineEntry
    {
        internal DocuWare.Platform.ServerClient.LineEntry Obj { get; } = obj;

        public bool Arrow
        {
            get => Obj.Arrow;
            set => Obj.Arrow = value;
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

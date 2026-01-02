using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class EntryBase(DocuWare.Platform.ServerClient.EntryBase obj) : IEntryBase
    {
        internal DocuWare.Platform.ServerClient.EntryBase Obj { get; } = obj;

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

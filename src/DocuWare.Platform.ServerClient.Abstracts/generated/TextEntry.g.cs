using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TextEntry(DocuWare.Platform.ServerClient.TextEntry obj) : ITextEntry
    {
        internal DocuWare.Platform.ServerClient.TextEntry Obj { get; } = obj;

        public IFont Font
        {
            get => new Font(Obj.Font);
            set => Obj.Font = ((Font)value).Obj;
        }

        public string Value
        {
            get => Obj.Value;
            set => Obj.Value = value;
        }

        public IAnnotationRectangle Location
        {
            get => new AnnotationRectangle(Obj.Location);
            set => Obj.Location = ((AnnotationRectangle)value).Obj;
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

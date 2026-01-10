using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TextStamp(DocuWare.Platform.ServerClient.TextStamp obj) : ITextStamp
    {
        internal DocuWare.Platform.ServerClient.TextStamp Obj { get; } = obj;

        public IFont Font
        {
            get => new Font(Obj.Font);
            set => Obj.Font = ((Font)value).Obj;
        }

        public string Content
        {
            get => Obj.Content;
            set => Obj.Content = value;
        }
    }
}

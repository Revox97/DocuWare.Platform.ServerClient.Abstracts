using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ContentType(SDK.ContentType obj) : IContentType
    {
        internal SDK.ContentType Obj { get; } = obj;

        public List<string> Text
        {
            get => Obj.Text;
            set => Obj.Text = value;
        }
    }
}

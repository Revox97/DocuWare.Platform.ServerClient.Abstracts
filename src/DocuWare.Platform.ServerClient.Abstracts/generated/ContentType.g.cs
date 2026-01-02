using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ContentType(DocuWare.Platform.ServerClient.ContentType obj) : IContentType
    {
        internal DocuWare.Platform.ServerClient.ContentType Obj { get; } = obj;

        public List<string> Text
        {
            get => Obj.Text;
            set => Obj.Text = value;
        }
    }
}

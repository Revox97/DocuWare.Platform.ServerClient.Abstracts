using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentIndexFieldKeywords(DocuWare.Platform.ServerClient.DocumentIndexFieldKeywords obj) : IDocumentIndexFieldKeywords
    {
        internal DocuWare.Platform.ServerClient.DocumentIndexFieldKeywords Obj { get; } = obj;

        public List<string> Keyword
        {
            get => Obj.Keyword;
            set => Obj.Keyword = value;
        }
    }
}

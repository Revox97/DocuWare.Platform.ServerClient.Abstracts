using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentIndexFieldKeywords(SDK.DocumentIndexFieldKeywords obj) : IDocumentIndexFieldKeywords
    {
        internal SDK.DocumentIndexFieldKeywords Obj { get; } = obj;

		public List<string> Keyword
		{
			get => Obj.Keyword;
			set => Obj.Keyword = value;
		}
    }
}

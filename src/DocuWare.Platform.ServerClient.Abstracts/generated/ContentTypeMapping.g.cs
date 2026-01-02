using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ContentTypeMapping(DocuWare.Platform.ServerClient.ContentTypeMapping obj) : IContentTypeMapping
    {
        internal DocuWare.Platform.ServerClient.ContentTypeMapping Obj { get; } = obj;

		public string GetContentTypeFromFileExtension(string fileExt) => Obj.GetContentTypeFromFileExtension(fileExt);
    }
}

using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ContentTypeMapping(SDK.ContentTypeMapping obj) : IContentTypeMapping
    {
        internal SDK.ContentTypeMapping Obj { get; } = obj;

        public IContentTypeMapping Default => new ContentTypeMapping(Obj.Default);

		public async string GetContentTypeFromFileExtension(string fileExt) => Obj.GetContentTypeFromFileExtension(fileExt);
    }
}

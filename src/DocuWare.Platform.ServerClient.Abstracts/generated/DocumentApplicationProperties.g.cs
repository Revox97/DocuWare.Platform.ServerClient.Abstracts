using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentApplicationProperties(DocuWare.Platform.ServerClient.DocumentApplicationProperties obj) : IDocumentApplicationProperties
    {
        internal DocuWare.Platform.ServerClient.DocumentApplicationProperties Obj { get; } = obj;

        public List<IDocumentApplicationProperty> DocumentApplicationProperty
        {
            get => Obj.DocumentApplicationProperty.Select(x => new DocumentApplicationProperty(x) as IDocumentApplicationProperty).ToList();
            set => Obj.DocumentApplicationProperty = value.Select(x => ((DocumentApplicationProperty)x).Obj).ToList();
        }
    }
}

using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentApplicationProperties(SDK.DocumentApplicationProperties obj) : IDocumentApplicationProperties
    {
        internal SDK.DocumentApplicationProperties Obj { get; } = obj;

		public List<IDocumentApplicationProperty> DocumentApplicationProperty
		{
			get => Obj.DocumentApplicationProperty.Select(x => new DocumentApplicationProperty(x) as IDocumentApplicationProperty).ToList();
			set => Obj.DocumentApplicationProperty = value.Select(x => ((DocumentApplicationProperty)x).Obj).ToList();
		}
    }
}

using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentAnnotations(SDK.DocumentAnnotations obj) : IDocumentAnnotations
    {
        internal SDK.DocumentAnnotations Obj { get; } = obj;

		public List<ISectionAnnotation> Annotations
		{
			get => Obj.Annotations.Select(x => new SectionAnnotation(x) as ISectionAnnotation).ToList();
			set => Obj.Annotations = value.Select(x => ((SectionAnnotation)x).Obj).ToList();
		}
    }
}

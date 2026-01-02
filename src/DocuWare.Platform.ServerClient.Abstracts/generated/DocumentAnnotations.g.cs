using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentAnnotations(DocuWare.Platform.ServerClient.DocumentAnnotations obj) : IDocumentAnnotations
    {
        internal DocuWare.Platform.ServerClient.DocumentAnnotations Obj { get; } = obj;

        public List<ISectionAnnotation> Annotations
        {
            get => Obj.Annotations.Select(x => new SectionAnnotation(x) as ISectionAnnotation).ToList();
            set => Obj.Annotations = value.Select(x => ((SectionAnnotation)x).Obj).ToList();
        }
    }
}

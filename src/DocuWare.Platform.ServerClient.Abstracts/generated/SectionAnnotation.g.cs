using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SectionAnnotation(DocuWare.Platform.ServerClient.SectionAnnotation obj) : ISectionAnnotation
    {
        internal DocuWare.Platform.ServerClient.SectionAnnotation Obj { get; } = obj;

        public List<ILayer> Annotation
        {
            get => Obj.Annotation.Select(x => new Layer(x) as ILayer).ToList();
            set => Obj.Annotation = value.Select(x => ((Layer)x).Obj).ToList();
        }

        public int SectionNumber
        {
            get => Obj.SectionNumber;
            set => Obj.SectionNumber = value;
        }

        public int PageNumber
        {
            get => Obj.PageNumber;
            set => Obj.PageNumber = value;
        }
    }
}

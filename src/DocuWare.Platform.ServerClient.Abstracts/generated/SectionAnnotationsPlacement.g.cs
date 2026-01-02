using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SectionAnnotationsPlacement(DocuWare.Platform.ServerClient.SectionAnnotationsPlacement obj) : ISectionAnnotationsPlacement
    {
        internal DocuWare.Platform.ServerClient.SectionAnnotationsPlacement Obj { get; } = obj;

        public IAnnotationsPlacement AnnotationsPlacement
        {
            get => new AnnotationsPlacement(Obj.AnnotationsPlacement);
            set => Obj.AnnotationsPlacement = ((AnnotationsPlacement)value).Obj;
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

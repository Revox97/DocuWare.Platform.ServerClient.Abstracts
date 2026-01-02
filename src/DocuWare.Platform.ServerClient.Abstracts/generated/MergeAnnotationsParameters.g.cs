using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class MergeAnnotationsParameters(DocuWare.Platform.ServerClient.MergeAnnotationsParameters obj) : IMergeAnnotationsParameters
    {
        internal DocuWare.Platform.ServerClient.MergeAnnotationsParameters Obj { get; } = obj;

        public int SectionNumber
        {
            get => Obj.SectionNumber;
            set => Obj.SectionNumber = value;
        }
    }
}

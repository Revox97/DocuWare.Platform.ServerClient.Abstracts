using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class MergeAnnotationsParameters(SDK.MergeAnnotationsParameters obj) : IMergeAnnotationsParameters
    {
        internal SDK.MergeAnnotationsParameters Obj { get; } = obj;

        public int SectionNumber
        {
            get => Obj.SectionNumber;
            set => Obj.SectionNumber = value;
        }
    }
}

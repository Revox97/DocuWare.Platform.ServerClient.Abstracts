using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class EnhanceImageParameters(DocuWare.Platform.ServerClient.EnhanceImageParameters obj) : IEnhanceImageParameters
    {
        internal DocuWare.Platform.ServerClient.EnhanceImageParameters Obj { get; } = obj;

        public int SectionNumber
        {
            get => Obj.SectionNumber;
            set => Obj.SectionNumber = value;
        }
    }
}

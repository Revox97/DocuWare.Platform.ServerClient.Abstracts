using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentAnnotationsPlacement(SDK.DocumentAnnotationsPlacement obj) : IDocumentAnnotationsPlacement
    {
        internal SDK.DocumentAnnotationsPlacement Obj { get; } = obj;

        public List<ISectionAnnotationsPlacement> Annotations
        {
            get => Obj.Annotations.Select(x => new SectionAnnotationsPlacement(x) as ISectionAnnotationsPlacement).ToList();
            set => Obj.Annotations = value.Select(x => ((SectionAnnotationsPlacement)x).Obj).ToList();
        }
    }
}

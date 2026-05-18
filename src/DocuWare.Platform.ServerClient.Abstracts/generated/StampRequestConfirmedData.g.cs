using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class StampRequestConfirmedData(SDK.StampRequestConfirmedData obj) : IStampRequestConfirmedData
    {
        internal SDK.StampRequestConfirmedData Obj { get; } = obj;

        public IAnnotationPoint Position
        {
            get => new AnnotationPoint(Obj.Position);
            set => Obj.Position = ((AnnotationPoint)value).Obj;
        }

        public int Section
        {
            get => Obj.Section;
            set => Obj.Section = value;
        }

        public int Page
        {
            get => Obj.Page;
            set => Obj.Page = value;
        }

        public int Layer
        {
            get => Obj.Layer;
            set => Obj.Layer = value;
        }

        public int DecisionId
        {
            get => Obj.DecisionId;
            set => Obj.DecisionId = value;
        }

        public string Comment
        {
            get => Obj.Comment;
            set => Obj.Comment = value;
        }
    }
}

using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Annotation(SDK.Annotation obj) : IAnnotation
    {
        internal SDK.Annotation Obj { get; } = obj;

        public List<ILayer> Layer
        {
            get => Obj.Layer.Select(x => new Layer(x) as ILayer).ToList();
            set => Obj.Layer = value.Select(x => ((Layer)x).Obj).ToList();
        }
    }
}

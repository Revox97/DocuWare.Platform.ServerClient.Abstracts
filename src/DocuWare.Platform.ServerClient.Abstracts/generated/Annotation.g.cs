using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Annotation(DocuWare.Platform.ServerClient.Annotation obj) : IAnnotation
    {
        internal DocuWare.Platform.ServerClient.Annotation Obj { get; } = obj;

        public List<ILayer> Layer
        {
            get => Obj.Layer.Select(x => new Layer(x) as ILayer).ToList();
            set => Obj.Layer = value.Select(x => ((Layer)x).Obj).ToList();
        }
    }
}

using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AnnotationsPlacement(DocuWare.Platform.ServerClient.AnnotationsPlacement obj) : IAnnotationsPlacement
    {
        internal DocuWare.Platform.ServerClient.AnnotationsPlacement Obj { get; } = obj;

        public List<object> Items
        {
            get => Obj.Items;
            set => Obj.Items = value;
        }
    }
}

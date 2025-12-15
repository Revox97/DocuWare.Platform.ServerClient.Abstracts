using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AnnotationsPlacement(SDK.AnnotationsPlacement obj) : IAnnotationsPlacement
    {
        internal SDK.AnnotationsPlacement Obj { get; } = obj;

        public List<object> Items
        {
            get => Obj.Items;
            set => Obj.Items = value;
        }
    }
}

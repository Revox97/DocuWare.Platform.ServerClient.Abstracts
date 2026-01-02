using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AnyExpression(DocuWare.Platform.ServerClient.AnyExpression obj) : IAnyExpression
    {
        internal DocuWare.Platform.ServerClient.AnyExpression Obj { get; } = obj;

        public object Item
        {
            get => Obj.Item;
            set => Obj.Item = value;
        }
    }
}

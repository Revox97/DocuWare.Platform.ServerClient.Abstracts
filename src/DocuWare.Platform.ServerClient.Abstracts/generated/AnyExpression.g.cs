using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AnyExpression(SDK.AnyExpression obj) : IAnyExpression
    {
        internal SDK.AnyExpression Obj { get; } = obj;

		public Object Item
		{
			get => Obj.Item;
			set => Obj.Item = value;
		}
    }
}

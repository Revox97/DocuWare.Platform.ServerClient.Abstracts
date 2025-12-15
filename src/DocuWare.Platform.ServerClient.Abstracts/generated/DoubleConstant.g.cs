using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DoubleConstant(SDK.DoubleConstant obj) : IDoubleConstant
    {
        internal SDK.DoubleConstant Obj { get; } = obj;

		public double? Value
		{
			get => Obj.Value;
			set => Obj.Value = value;
		}
    }
}

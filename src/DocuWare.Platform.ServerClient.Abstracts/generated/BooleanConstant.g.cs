using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BooleanConstant(SDK.BooleanConstant obj) : IBooleanConstant
    {
        internal SDK.BooleanConstant Obj { get; } = obj;

		public bool? Value
		{
			get => Obj.Value;
			set => Obj.Value = value;
		}
    }
}

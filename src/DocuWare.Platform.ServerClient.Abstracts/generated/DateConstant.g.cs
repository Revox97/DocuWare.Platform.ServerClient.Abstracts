using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DateConstant(SDK.DateConstant obj) : IDateConstant
    {
        internal SDK.DateConstant Obj { get; } = obj;

		public DateTime? Value
		{
			get => Obj.Value;
			set => Obj.Value = value;
		}
    }
}
